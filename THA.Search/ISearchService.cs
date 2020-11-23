using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace THA.Search
{
    public interface ISearchService
    {
        IReadOnlyCollection<Result> FindResults(string search);
    }
    
}