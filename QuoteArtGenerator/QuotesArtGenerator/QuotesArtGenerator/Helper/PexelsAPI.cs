using PexelsNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesArtGenerator.Helper
{
    public class PexelsAPI
    {
        public PexelsClient Client { get; set; }

        public PexelsAPI()
        {
            Client = new PexelsClient("563492ad6f91700001000001c44c2fced4954bae8ca7f3ee1f27c348");
            var results = Client.SearchAsync("business").Result;

            foreach (var image in results.Photos)
            {
                Console.WriteLine(image.Url);
            }
        }
    }
}
