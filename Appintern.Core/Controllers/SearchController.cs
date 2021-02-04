using Appintern.Core.Helpers;
using Appintern.Core.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Web.Composing;
using Umbraco.Web.Mvc;

namespace Appintern.Core.Controllers
{
    public class SearchController : SurfaceController
    {
        #region Private Variables and Methods

        private SearchHelper _searchHelper
        {
            get { return new SearchHelper(Current.UmbracoHelper); }
        }

        private string PartialViewPath(string name)
        {
            return $"~/Views/Partials/SearchAll/{name}.cshtml";
        }

        private List<SearchGroup> GetSearchGroups(Search1ViewModel model)
        {
            List<SearchGroup> searchGroups = null;
            if (!string.IsNullOrEmpty(model.FieldPropertyAliases))
            {
                searchGroups = new List<SearchGroup>();
                searchGroups.Add(new SearchGroup(model.FieldPropertyAliases.Split(','), model.SearchTerm.Split(' ')));
            }
            return searchGroups;
        }

        #endregion

        #region Controller Actions

        [HttpGet]
        public ActionResult RenderSearchForm(string query, string docTypeAliases, string fieldPropertyAliases, int pageSize, int pagingGroupSize)
        {
            Search1ViewModel model = new Search1ViewModel();
            if (!string.IsNullOrEmpty(query))
            {
                model.SearchTerm = query;
                model.DocTypeAliases = docTypeAliases;
                model.FieldPropertyAliases = fieldPropertyAliases;
                model.PageSize = pageSize;
                model.PagingGroupSize = pagingGroupSize;
                model.SearchGroups = GetSearchGroups(model);
                model.SearchResults = _searchHelper.GetSearchResults(model, Request.Form.AllKeys);
            }
            return PartialView(PartialViewPath("_SearchForm"), model);
        }

        [HttpPost]
        public ActionResult SubmitSearchForm(Search1ViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model.SearchTerm))
                {
                    model.SearchTerm = model.SearchTerm;
                    model.SearchGroups = GetSearchGroups(model);
                    model.SearchResults = _searchHelper.GetSearchResults(model, Request.Form.AllKeys);
                }
                return RenderSearchResults(model.SearchResults);
            }
            return null;
        }

        public ActionResult RenderSearchResults(SearchResultsModel model)
        {
            return PartialView(PartialViewPath("_SearchResults"), model);
        }
        #endregion
    }
}