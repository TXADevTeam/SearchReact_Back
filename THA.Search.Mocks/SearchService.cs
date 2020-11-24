using System;
using System.Collections.Generic;
using System.Linq;


namespace THA.Search.Mocks
{
    public class SearchService : ISearchService
    {
        
        public IReadOnlyCollection<Result> FindResults(string search)
        {
            if (search is null)
                throw new ArgumentNullException();
            if (search == "")
                throw new ArgumentException();
            search = search.ToUpper();
            IReadOnlyCollection<Result> results = Values.Data()
                .Where(r => r.Description.ToUpper().Contains(search))
                .OrderBy(r => r.Id)
                .ToList();
            return results;
        }
        
        
    }
}