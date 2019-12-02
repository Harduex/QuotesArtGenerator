using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QuotesArtGenerator.Models;

namespace ApiServices
{
    class QuoteService : IQuoteObject
    {
        public Task<QuoteObject> CreateQuoteAsync(QuoteObject task)
        {
            throw new NotImplementedException();
        }

        public Task DeleteQuoteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<QuoteObject>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<QuoteObject> GetQuoteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<QuoteObject> UpdateQuoteAsync(QuoteObject task)
        {
            throw new NotImplementedException();
        }
    }
}
