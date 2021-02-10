using Appintern.Core.Helpers;
using Appintern.Core.Models;
using Appintern.Core.Services;
using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Composing;
using Umbraco.Web.Mvc;

namespace Appintern.Core.Controllers
{
    public class SearchController : SurfaceController
    {
        #region Private Variables and Methods

        private readonly IDataTypeValueService _dataTypeValueService;

        public SearchController(IDataTypeValueService dataTypeValueService)
        {
            _dataTypeValueService = dataTypeValueService;
        }
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

        #region CONTROLLER ACTIONS

        #region Basic Search Form

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

        #endregion

        #region Search From with additional Criteria

        private List<SearchGroup> GetSearch2Groups(Search2ViewModel model)
        {
            List<SearchGroup> searchGroups = null;
            if (!string.IsNullOrEmpty(model.FieldPropertyAliases))
            {
                searchGroups = new List<SearchGroup>();
                searchGroups.Add(new SearchGroup(model.FieldPropertyAliases.Split(','), model.SearchTerm.Split(' ')));
            }
            return searchGroups;
        }

        public ActionResult RenderSearch2Form(string query, string docTypeAliases, string fieldPropertyAliases, int pageSize, int pagingGroupSize)
        {
            IEnumerable<SelectListItem> categories = _dataTypeValueService.GetItemsFromValueListDataType("CheckboxList Category", null);

            Search2ViewModel model = new Search2ViewModel();

            model.Categories = categories;

            if (!string.IsNullOrEmpty(query))
            {
                model.SearchTerm = query;
                model.Category = "";
                model.DocTypeAliases = docTypeAliases;
                model.FieldPropertyAliases = fieldPropertyAliases;
                model.PageSize = pageSize;
                model.PagingGroupSize = pagingGroupSize;
                model.SearchGroups = GetSearch2Groups(model);
                model.SearchResults = _searchHelper.GetSearch2Results(model, Request.Form.AllKeys);
            }
            return PartialView(PartialViewPath("_Search2Form"), model);
        }

        public ActionResult SubmitSearch2Form(Search2ViewModel model)
        {
            IEnumerable<SelectListItem> categories = _dataTypeValueService.GetItemsFromValueListDataType("CheckboxList Category", null);
            model.Categories = categories;

            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model.SearchTerm))
                {
                    model.SearchTerm = model.SearchTerm;
                    model.SearchGroups = GetSearch2Groups(model);
                    model.SearchResults = _searchHelper.GetSearch2Results(model, Request.Form.AllKeys);
                }
                return RenderSearch2Results(model.SearchResults);
            }
            return null;
        }

        public ActionResult RenderSearch2Results(SearchResultsModel model)
        {
            return PartialView(PartialViewPath("_Search2Results"), model);
        }

        #endregion

        public ActionResult RenderSearchResults(SearchResultsModel model)
        {
            return PartialView(PartialViewPath("_SearchResults"), model);
        }

        #endregion
    }
}