using QuotesArtGenerator.Models;
using System;
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
            
        }

        public int TotalItems { get; private set; }
        public int TotalPages { get; private set; }
        public int Skip { get; private set; }
        public int Take { get; private set; }

    }
}
