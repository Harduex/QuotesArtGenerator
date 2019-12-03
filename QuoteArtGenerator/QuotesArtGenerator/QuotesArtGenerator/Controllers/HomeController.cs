using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PexelsNet;
using QuotesArtGenerator.Data;
using QuotesArtGenerator.Models;
using ReflectionIT.Mvc.Paging;
using WikipediaNet;
using WikipediaNet.Objects;


namespace QuotesArtGenerator.Controllers
{
    public class HomeController : Controller
    {
        Random random = new Random();

        public IActionResult Index()
        {
            QuotesList quotesList = new QuotesList();

            int Id = random.Next(0, quotesList.Quotes.Count);
            Quote quote = quotesList.Quotes[Id];

            return View(quote);
        }

        public IActionResult GetImageUrl(string category)
        {
            string ImgUrl = PixabayAPI.GetPixabayUrl(category).Result;

            return Redirect(ImgUrl);
        }

        public IActionResult GetWikiUrl(string author)
        {
            Wikipedia wikipedia = new Wikipedia();
            string UrlFound = null;
            QueryResult results = wikipedia.Search(author);
            UrlFound = results.Search[0].Url.AbsoluteUri;

            return Redirect(UrlFound);
        }

        public IActionResult List(int page)
        {
            QuotesList quotesList = new QuotesList();

            var skip = page *= 10;

            var range = quotesList.Quotes.Skip(skip - 10);
            range = range.Take(10);

            return View(range);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
