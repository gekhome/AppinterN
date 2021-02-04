using Appintern.Core.Models;
using System.Collections.Specialized;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Appintern.Core.Controllers
{
    public class SearchSurfaceController : SurfaceController
    {
        public ActionResult SubmitForm(SearchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var queryString = new NameValueCollection();
            if (!string.IsNullOrWhiteSpace(model.Query))
            {
                queryString.Add("query", model.Query);
            }

            if (!string.IsNullOrWhiteSpace(model.Category))
            {
                queryString.Add("category", model.Category);
            }

            if (!string.IsNullOrWhiteSpace(model.Page))
            {
                queryString.Add("page", model.Page);
            }

            return RedirectToCurrentUmbracoPage(queryString);
        }

    }
}
