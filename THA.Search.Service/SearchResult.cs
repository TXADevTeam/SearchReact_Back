using System.Collections.Generic;
using Data;
using ISearch;
using THA.Search.Moq.Models;

namespace THA.Search.Service
{
    public class SearchResult : ISearchService
    {
        private readonly Values _values;

        public SearchResult(Values values)
        {
            _values = values;
        }
        public IEnumerable<Result> ResultList(string search)
        {
            IEnumerable<Result> results = (IEnumerable<Result>) _values.texts; 
            return results;
        }
        
    }
}