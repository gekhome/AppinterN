using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;

namespace Appintern.Core.Models
{
    public class Search1ViewModel
    {
        public string SearchTerm { get; set; }

        public string DocTypeAliases { get; set; }

        public string FieldPropertyAliases { get; set; }

        public int PageSize { get; set; }

        public int PagingGroupSize { get; set; }

        public List<SearchGroup> SearchGroups { get; set; }

        public SearchResultsModel SearchResults { get; set; }
    }

    public class Search2ViewModel
    {
        public string SearchTerm { get; set; }

        [Display(Name = "Category")]
        public string Category { get; set; }

        public string DocTypeAliases { get; set; }

        public string FieldPropertyAliases { get; set; }

        public int PageSize { get; set; }

        public int PagingGroupSize { get; set; }

        public List<SearchGroup> SearchGroups { get; set; }

        public SearchResultsModel SearchResults { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

    }


    public class SearchGroup
    {
        public string[] FieldsToSearchIn { get; set; }

        public string[] SearchTerms { get; set; }

        public SearchGroup(string[] fieldsToSearchIn, string[] searchTerms)
        {
            FieldsToSearchIn = fieldsToSearchIn;
            SearchTerms = searchTerms;
        }
    }

    public class SearchResultsModel
    {
        public string SearchTerm { get; set; }

        public IEnumerable<IPublishedContent> Results { get; set; }

        public bool HasResults { get { return Results != null && Results.Count() > 0; } }

        public int PageNumber { get; set; }

        public int PageCount { get; set; }

        public int TotalItemCount { get; set; }

        public PagingBoundsModel PagingBounds { get; set; }
    }

    public class PagingBoundsModel
    {
        public int StartPage { get; set; }

        public int EndPage { get; set; }

        public bool ShowFirstButton { get; set; }

        public bool ShowLastButton { get; set; }

        public PagingBoundsModel(int startPage, int endPage, bool showFirstButton, bool showLastButton)
        {
            StartPage = startPage;
            EndPage = endPage;
            ShowFirstButton = showFirstButton;
            ShowLastButton = showLastButton;
        }
    }
}
