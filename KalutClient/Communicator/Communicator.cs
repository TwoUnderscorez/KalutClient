using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace Communicator
{
    public class Communicator
    {
        const string BASE_URI = "https://planq.tk:25565";
        async public static Task<StandartResponse> GET(string uri)
        {
            string myContent;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(
                        string.Format("{0}{1}",
                        BASE_URI,
                        uri)))
                {
                    using (HttpContent content = response.Content)
                    {
                        myContent = await content.ReadAsStringAsync();
                    }
                }
            }
            return JsonConvert.DeserializeObject<StandartResponse>(myContent);
        }
        async public static Task<StandartResponse> POST(string uri, Dictionary<string, string> data)
        {
            string myContent;
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(
                        string.Format("{0}{1}",
                        BASE_URI,
                        uri),
                        new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")))
                {
                    using (HttpContent content = response.Content)
                    {
                        myContent = await content.ReadAsStringAsync();
                    }
                }
            }
            return JsonConvert.DeserializeObject<StandartResponse>(myContent);
        }
        async public static Task<bool> Authenticate(string Username, string Password)
        {
            var data = new Dictionary<string, string>();
            data.Add("Username", Username);
            data.Add("Password", Password);
            StandartResponse rsp = await POST("/auth", data);
            return rsp.Data["Auth"]=="True";
        }
    }
}
