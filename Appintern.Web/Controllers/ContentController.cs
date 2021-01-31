using Appintern.Core.Helpers;
using Appintern.Core.Models;
using Appintern.Web.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.Composing;
using Umbraco.Web.Mvc;
using CM = Umbraco.Web.PublishedModels;

namespace Appintern.Web.Controllers
{
    public class ContentController :   SurfaceController
    {
        // Instantiate the HomeHelper
        HomeHelper _homeHelper => new HomeHelper(CurrentPage, Current.UmbracoHelper);
        private UmbracoHelper _uHelper;

        private int _homePageId = 1080;

        private const string HOMEPAGE_DOCTYPE_ALIAS = "home";
        private const string FAQ_PAGE_DOCTYPE_ALIAS = "faqList";

        // intstantiate through dependency injection
        public ContentController(UmbracoHelper uhelper)
        {
            _uHelper = uhelper;
        }

        private string GetContentViewPath(string name)
        {
            return $"~/Views/Partials/Content/{name}.cshtml";
        }

        private string GetFaqViewPath(string name)
        {
            return $"~/Views/Partials/Faq/{name}.cshtml";
        }

        private string GetServicesViewPath(string name)
        {
            return $"~/Views/Partials/Services/{name}.cshtml";
        }

        public ActionResult RenderNavigation()
        {
            return PartialView(GetContentViewPath("_MainNavigation"));
        }

        public ActionResult RenderHome()
        {           
            return RedirectToUmbracoPage(_homePageId);
        }

        public ActionResult RenderTitleControls()
        {
            return PartialView(GetContentViewPath("_TitleControls"));
        }

        public ActionResult RenderTargetedSection()
        {
            List<TargetedItemModel> model = _homeHelper.GetTargetedItemsModel();

            return PartialView(GetContentViewPath("_TargetedSection"), model);
        }

        public ActionResult RenderServicesSection()
        {
            ServicesModel model = _homeHelper.GetServicesModel();

            return PartialView(GetContentViewPath("_ServicesSection"), model);
        }

        
        public ActionResult RenderFaqList()
        {
            List<FaqViewModel> model = new List<FaqViewModel>();

            IPublishedContent homePage = CurrentPage.AncestorOrSelf(HOMEPAGE_DOCTYPE_ALIAS);
            IPublishedContent faqPage = homePage.Children.Where(x => x.ContentType.Alias == FAQ_PAGE_DOCTYPE_ALIAS).FirstOrDefault();

            foreach (IPublishedContent item in faqPage.Children.OrderBy(x => x.Name))
            {
                string question = item.GetProperty("question").GetValue().ToString();

                var answer = (IHtmlString)item.GetProperty("answer").GetValue();

                model.Add(new FaqViewModel(question, answer));
            }

            return PartialView(GetFaqViewPath("_FaqArticles"), model);
        }

        public ActionResult RenderServicesMain()
        {
            ServicesMainModel model = _homeHelper.GetServicesMainModel();

            return PartialView(GetServicesViewPath("_ServicesMain"), model);
        }

        public ActionResult RenderServicesSidebar()
        {
            ServicesSidebarModel model = _homeHelper.GetServicesSidebarModel();

            return PartialView(GetServicesViewPath("_ServicesSidebar"), model);
        }


    }
}