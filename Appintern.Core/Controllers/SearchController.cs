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

        public ActionResult RenderSearchResults(SearchResultsModel model)
        {
            return PartialView(PartialViewPath("_SearchResults"), model);
        }

        #endregion

        #region Search Form with criterion Category

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

        #region Search Form Apprenticeships with multiple criteria

        private List<SearchGroup> GetSearch3Groups(Search3ViewModel model)
        {
            List<SearchGroup> searchGroups = null;
            if (!string.IsNullOrEmpty(model.FieldPropertyAliases))
            {
                searchGroups = new List<SearchGroup>();
                searchGroups.Add(new SearchGroup(model.FieldPropertyAliases.Split(','), model.SearchTerm.Split(' ')));
            }
            return searchGroups;
        }

        public ActionResult RenderSearch3Form(string query, string docTypeAliases, string fieldPropertyAliases, int pageSize, int pagingGroupSize)
        {
            IEnumerable<SelectListItem> jobSectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
            IEnumerable<SelectListItem> durations = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Duration", null);
            IEnumerable<SelectListItem> commitments = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Commitment", null);
            IEnumerable<SelectListItem> compensations = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Compensation", null);
            IEnumerable<SelectListItem> statuses = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Status", null);

            Search3ViewModel model = new Search3ViewModel();

            model.JobSectors = jobSectors;
            model.Durations = durations;
            model.Commitments = commitments;
            model.Compensations = compensations;
            model.Statuses = statuses;

            if (!string.IsNullOrEmpty(query))
            {
                model.SearchTerm = query;
                model.JobSector = "";
                model.Duration = "";
                model.Commitment = "";
                model.Compensation = "";
                model.Status = "";
                model.DocTypeAliases = docTypeAliases;
                model.FieldPropertyAliases = fieldPropertyAliases;
                model.PageSize = pageSize;
                model.PagingGroupSize = pagingGroupSize;
                model.SearchGroups = GetSearch3Groups(model);
                model.SearchResults = _searchHelper.GetSearch3Results(model, Request.Form.AllKeys);
            }
            return PartialView(PartialViewPath("_Search3Form"), model);
        }

        public ActionResult SubmitSearch3Form(Search3ViewModel model)
        {
            IEnumerable<SelectListItem> jobSectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
            IEnumerable<SelectListItem> durations = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Duration", null);
            IEnumerable<SelectListItem> commitments = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Commitment", null);
            IEnumerable<SelectListItem> compensations = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Compensation", null);
            IEnumerable<SelectListItem> statuses = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Status", null);

            model.JobSectors = jobSectors;
            model.Durations = durations;
            model.Commitments = commitments;
            model.Compensations = compensations;
            model.Statuses = statuses;

            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model.SearchTerm))
                {
                    model.SearchTerm = model.SearchTerm;
                    model.SearchGroups = GetSearch3Groups(model);
                    model.SearchResults = _searchHelper.GetSearch3Results(model, Request.Form.AllKeys);
                }
                return RenderSearch3Results(model.SearchResults);
            }
            return null;
        }

        public ActionResult RenderSearch3Results(SearchResultsModel model)
        {
            return PartialView(PartialViewPath("_Search3Results"), model);
        }

        #endregion

        #endregion
    }
}