using Examine;
using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;

namespace Appintern.Core.Services
{
    public interface ISearchService
    {
        IEnumerable<ISearchResult> GetPageOfSearchResults(string searchTerm, string category, int pageNumber, out long totalItemCount, 
                                                          string[] docTypeAliases, string searchType, int pageSize = 10);

        IEnumerable<IPublishedContent> GetPageOfContentSearchResults(string searchTerm, string category, int pageNumber, out long totalItemCount, 
                                                                     string[] docTypeAliases, int pageSize = 10);
    }
}
