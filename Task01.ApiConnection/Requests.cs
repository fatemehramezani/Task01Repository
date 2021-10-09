using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Task01.Common;

namespace Task01.ApiConnection
{
    public class Requests
    {
        public Requests(string baseURL)
        {
            this.BaseURL = baseURL;
        }

        public string BaseURL { get; set; }

        public (T values, string log) CallRequest<T>(string URL, string requestURI = null, APIMethod method = APIMethod.GET, object bodyContent = null)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{BaseURL}{URL}");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = null;
                HttpContent content = null;

                if (bodyContent != null && !typeof(HttpContent).IsAssignableFrom(bodyContent.GetType()))
                {
                    content = new StringContent(bodyContent is string ? bodyContent.ToString() : JsonConvert.SerializeObject(bodyContent));
                    content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                }
                else
                {
                    content = bodyContent as HttpContent;
                }

                switch (method)
                {
                    case APIMethod.GET:
                        response = client.GetAsync(requestURI).Result;
                        break;
                    case APIMethod.PATCH:
                        response = client.PatchAsync(requestURI, content).Result;
                        break;
                    case APIMethod.DELETE:
                    case APIMethod.POST:
                    case APIMethod.PUT:
                        throw new NotImplementedException();
                    default:
                        break;
                }
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
