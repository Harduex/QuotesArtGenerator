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
        QuotesList quotesList = new QuotesList();
        public List<string> Categories { get; set; }
        public Random Random { get; set; }
        public string RandomCategory { get; set; }

        public HomeController()
        {
            Random = new Random();
            List<string> categories = new List<string>();
            foreach (var item in quotesList.Quotes)
            {
                categories.Add(item.CATEGORY);
            }
            Categories = categories.Distinct().ToList();
            RandomCategory = Categories[Random.Next(0, Categories.Count)];
        }


        public IActionResult Index(string category = null)
        {
            if (category == null)
            {
                category = RandomCategory;
            }
            var quotesByCategory = new List<Quote>();

            foreach (var item in quotesList.Quotes)
            {
                if (item.CATEGORY == category)
                {
                    quotesByCategory.Add(item);
                }
            }

            int Id = Random.Next(0, quotesByCategory.Count);
            Quote quote = quotesByCategory[Id];

            ViewBag.data = Categories;

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

        public IActionResult List(int page = 1, string category = "age")
        {
            var quotesByCategory = new List<Quote>();

            foreach (var quote in quotesList.Quotes)
            {
                if(quote.CATEGORY==category)
                {
                    quotesByCategory.Add(quote);
                }
            }

            Pager pager = new Pager(quotesList.Quotes.Count, page, 10);

            ViewBag.data = Categories;
            ViewBag.category = category;
            ViewBag.pager = pager;

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
