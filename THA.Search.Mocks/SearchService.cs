using System.Collections.Generic;
using System.Linq;

namespace THA.Search.Mocks
{
    public class SearchService : ISearchService
    {
        
        public IReadOnlyCollection<Result> FindResults(string search)
        {
            IReadOnlyCollection<Result> results = Values.Data()
                .Where(r => r.Description.Contains(search))
                .OrderBy(r => r.Id)
                .ToList();
            return results;
        }
    }
}