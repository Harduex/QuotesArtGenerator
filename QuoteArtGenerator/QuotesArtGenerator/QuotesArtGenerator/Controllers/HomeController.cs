using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PexelsNet;
using QuotesArtGenerator.Data;
using QuotesArtGenerator.Helper;
using QuotesArtGenerator.Models;
using WikipediaNet;
using WikipediaNet.Objects;

namespace QuotesArtGenerator.Controllers
{
    public class HomeController : Controller
    {
        Random random = new Random();

        public IActionResult Index(int id)
        {
            QuotesList quotesList = new QuotesList();

            int Id = random.Next(0, quotesList.Quotes.Count);
            Quote quote = quotesList.Quotes[Id];
            //quote.Id = Id;

            return View(quote);
        }

        public IActionResult GetPhotoUrl()
        {
            var Client = new PexelsClient("563492ad6f91700001000001c44c2fced4954bae8ca7f3ee1f27c348");
            var results = Client.SearchAsync("music").Result;
            int id = random.Next(0, 2);
            string photoUrl = results.Photos[id].Url;

            return Redirect(photoUrl);
        }

        public IActionResult GetWikiUrl(string author)
        {
            Wikipedia wikipedia = new Wikipedia();
            //wikipedia.Limit = 2;
            string UrlFound = null;
            QueryResult results = wikipedia.Search(author);
            UrlFound = results.Search[0].Url.AbsoluteUri;

            return Redirect(UrlFound);
        }

        public IActionResult List()
        {
            QuotesList quotesList = new QuotesList();

            return View(quotesList.Quotes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
