using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientHandler
{
    class Program
    {

        public static RootObject Hits { get; set; }

        static void Main(string[] args)
        {
            string ImgUrl = GetPixabayUrl("cat").Result;
           
            Console.WriteLine(ImgUrl);
            ChromeLauncher.OpenLink(ImgUrl);

            Console.ReadLine();
            Console.ReadKey();
        }

        private static async Task<string> GetPixabayUrl(string category)
        {
            string apiKey = "14483871-abffdf4f8a7aee44f86ad28db";
            string baseUrl = "https://pixabay.com/api/?key=" + apiKey + /*"&category=" + category*/ "&q=" + category;

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(baseUrl))

            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    DeserializeJson(data);
                    return Hits.hits[0].largeImageURL;
                    //foreach (var hit in Hits.hits)
                    //{
                    //    Console.WriteLine(hit.webformatURL);
                    //}
                    //Console.WriteLine(data);
                }
                return "null";
            }

        }

        private static void DeserializeJson(string data)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Hits = JsonConvert.DeserializeObject<RootObject>(data);
        }

        //static async void GetData()
        //{
        //    string baseUrl = "http://api.open-notify.org/iss-now.json";

        //    using (HttpClient client = new HttpClient())
        //    using (HttpResponseMessage res = await client.GetAsync(baseUrl))

        //    using (HttpContent content = res.Content)
        //    {
        //        string data = await content.ReadAsStringAsync();
        //        if (data != null)
        //        {
        //            Console.WriteLine(data);
        //        }
        //    }

        //}
    }


}