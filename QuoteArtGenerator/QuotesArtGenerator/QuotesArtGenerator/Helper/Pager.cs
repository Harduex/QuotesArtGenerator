using QuotesArtGenerator.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesArtGenerator.Helper
{
    public class Pager
    {
        public Pager(int totalItems, int page, int pageSize)
        {
            Skip = (page - 1) * pageSize;
            Take = pageSize;
            TotalItems = totalItems;
            TotalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
            CurrentPage = page;
            PageSize = pageSize;
        }

        public int TotalPagesByCategory(IEnumerable<Quote> list)
        {
            int Total = list.Count()/PageSize;

            return Total;
        }

        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }

    }
}
