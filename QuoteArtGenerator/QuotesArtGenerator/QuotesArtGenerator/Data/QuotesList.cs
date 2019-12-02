using Newtonsoft.Json;
using QuotesArtGenerator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesArtGenerator.Data
{
    public class QuotesList
    {
        public List<Quote> Quotes { get; set; }
        public string JsonFilePath { get; set; }

        public QuotesList()
        {
            //Json deserialization
            DeserializeJson("Data", "Quotes.json");
        }

        private void DeserializeJson(string dir, string file)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string JsonFilePath = Path.Combine(currentDirectory, dir, file);
            Quotes = JsonConvert.DeserializeObject<List<Quote>>(File.ReadAllText(JsonFilePath));
        }
    }
}
