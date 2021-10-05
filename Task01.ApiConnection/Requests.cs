using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Task01.Data;

namespace Task01.ApiConnection
{
    public class Requests
    {
        public Requests(string baseURL)
        {
            this.BaseURL = baseURL;
        }

        public string BaseURL { get; set; }

        public void GetOrders(string status = "IN_PROGRESS")
        {
            var URL = $"{BaseURL}&statuses={status}";
            var urlParameters = string.Empty;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync(urlParameters).Result;
                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = JObject.Parse(response.Content.ReadAsStringAsync().Result)["Content"].ToString();
                    var merchantOrderResponses = JsonConvert.DeserializeObject<List<MerchantOrderResponse>>(jsonContent);
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }

            }
        }
    }
}
