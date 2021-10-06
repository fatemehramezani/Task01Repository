using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Task01.ApiConnection
{
    public class Requests
    {
        public Requests(string baseURL)
        {
            this.BaseURL = baseURL;
        }

        public string BaseURL { get; set; }

        public (T values, string log) CallRequest<T>(string URL, string urlParameters = null)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{BaseURL}{URL}");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync(urlParameters).Result;
                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = JObject.Parse(response.Content.ReadAsStringAsync().Result)["Content"].ToString();
                    var result = JsonConvert.DeserializeObject<T>(jsonContent);
                    return (result, $"'{typeof(T)}' is ready");
                }
                else
                {
                    return (default(T), $"{(int)response.StatusCode} ({response.ReasonPhrase})");
                }

            }
        }
    }
}
