using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesArtGenerator
{
    public class RootObject
    {
        public int totalHits { get; set; }
        public List<Hit> hits { get; set; }
        public int total { get; set; }
    }
}
