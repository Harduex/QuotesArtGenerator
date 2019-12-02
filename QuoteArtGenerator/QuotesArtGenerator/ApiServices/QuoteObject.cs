using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesArtGenerator.Models
{
    public class QuoteObject
    {
        public int id { get; set; }
        public string quoteText { get; set; }
        public string author { get; set; }
    }
}
