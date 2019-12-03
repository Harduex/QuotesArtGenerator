using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PexelsNet;
using QuotesArtGenerator.Data;
using QuotesArtGenerator.Helper;
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

            List<string> categories = new List<string>();
            foreach (var item in quotesList.Quotes)
            {
                categories.Add(item.CATEGORY);
            }
            categories = categories.Distinct().ToList();

            ViewBag.data = categories;

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

        public IActionResult List(int page, string category = "age")
        {
            QuotesList quotesList = new QuotesList();
            var quotesByCategory = new List<Quote>();

            foreach (var quote in quotesList.Quotes)
            {
                if(quote.CATEGORY==category)
                {
                    quotesByCategory.Add(quote);
                }
            }

            Pager pager = new Pager(quotesList.Quotes.Count, page, 10);

            //var result = quotesList.Quotes.Skip(pager.Skip).Take(pager.Take);

            List<string> categories = new List<string>();
            foreach (var quote in quotesList.Quotes)
            {
                categories.Add(quote.CATEGORY);
            }
            categories = categories.Distinct().ToList();

            ViewBag.data = categories;
            ViewBag.category = category;

            var result = quotesByCategory.Skip(pager.Skip).Take(pager.Take);

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
