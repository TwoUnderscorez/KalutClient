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
            return rsp.Data["Auth"].ToString() == "True";
        }
        async public static Task<Dictionary<string, string>> GetQuizDescByUID(int uid)
        {
            StandartResponse rsp = await GET(string.Format("/quizes/get_quiz_info_by_uid&{0}", uid));
            return rsp.Data;
        }
        async public static Task<Dictionary<string, string>> GetQuizDataByUID(int uid)
        {
            StandartResponse rsp = await GET(string.Format("/quizes/get_quiz_data_by_uid&{0}", uid));
            return rsp.Data;
        }
        async public static Task<Dictionary<int, Dictionary<string, string>>> GetUserKalutsInfo(string Username, string Password)
        {
            var pdata = new Dictionary<string, string>();
            pdata.Add("Username", Username);
            pdata.Add("Password", Password);
            StandartResponse rsp = await POST("/quizes/get_user_kaluts_info", pdata);
            var retdata = new Dictionary<int, Dictionary<string, string>>();
            foreach (string uid in rsp.Data.Keys)
            {
                retdata.Add(int.Parse(uid), JsonConvert.DeserializeObject<Dictionary<string, string>>(rsp.Data[uid]));
            }
            return retdata;
        }
        async public static Task<Dictionary<int, Dictionary<string, string>>> GetUserFavKalutsInfo(string Username, string Password)
        {
            var pdata = new Dictionary<string, string>();
            pdata.Add("Username", Username);
            pdata.Add("Password", Password);
            StandartResponse rsp = await POST("/quizes/get_user_fav_kaluts_info", pdata);
            var retdata = new Dictionary<int, Dictionary<string, string>>();
            foreach (string uid in rsp.Data.Keys)
            {
                retdata.Add(int.Parse(uid), JsonConvert.DeserializeObject<Dictionary<string, string>>(rsp.Data[uid]));
            }
            return retdata;
        }
        async public static Task<Dictionary<int, Dictionary<string, string>>> GetAllKalutInfo()
        {
            StandartResponse rsp = await GET("/quizes/get_all_quizes_info");
            var retdata = new Dictionary<int, Dictionary<string, string>>();
            foreach (string uid in rsp.Data.Keys)
            {
                retdata.Add(int.Parse(uid), JsonConvert.DeserializeObject<Dictionary<string, string>>(rsp.Data[uid]));
            }
            return retdata;
        }
        async public static Task<StandartResponse> AddKalut(string Username, string Password, string Info, string Quetions)
        {
            var data = new Dictionary<string, string>();
            data.Add("Username", Username);
            data.Add("Password", Password);
            data.Add("QuizData", Quetions);
            data.Add("QuizDescription", Info);
            StandartResponse rsp = await POST("/quizes/add", data);
            return rsp;
        }
        async public static Task<Dictionary<string, string>> CreateRoom(int uid)
        {
            StandartResponse rsp = await GET(string.Format("/rooms/create_room&{0}", uid));
            return rsp.Data;
        }
    }
}
