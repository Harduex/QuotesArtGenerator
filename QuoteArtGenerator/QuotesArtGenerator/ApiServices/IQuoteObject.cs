using QuotesArtGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiServices
{
    public interface IQuoteObject
    {
        Task<List<QuoteObject>> GetAllAsync();
        Task<QuoteObject> GetQuoteAsync(int id);
        Task<QuoteObject> CreateQuoteAsync(QuoteObject task);
        Task<QuoteObject> UpdateQuoteAsync(QuoteObject task);
        Task DeleteQuoteAsync(int id);
    }
}
