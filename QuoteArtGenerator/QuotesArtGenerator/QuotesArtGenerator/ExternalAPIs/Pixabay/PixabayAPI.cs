﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuotesArtGenerator
{
    public static class PixabayAPI
    {

        public static RootObject Hits { get; set; }

        //static void Main(string[] args)
        //{
        //    string ImgUrl = GetPixabayUrl("inspiration").Result;
           
        //    Console.WriteLine(ImgUrl);
        //    Console.ReadLine();
        //    Console.ReadKey();
        //}

        public static async Task<string> GetPixabayUrl(string category)
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
                    Random rand = new Random();
                    return Hits.hits[rand.Next(0,Hits.hits.Count)].largeImageURL;
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