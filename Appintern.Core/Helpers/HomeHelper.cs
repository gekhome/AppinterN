using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Models.PublishedContent;
using Appintern.Core.Models;

namespace Appintern.Core.Helpers
{
    public class HomeHelper
    {
        private IPublishedContent _currentPage;
        private UmbracoHelper _uHelper;

        private IPublishedContent _homePage;
        private int _MaxServices = 3;
        private const string SERVICES_PAGE_DOCTYPE_ALIAS = "services";

        public HomeHelper(IPublishedContent currentPage, UmbracoHelper uHelper, string homeDocTypeAlias = "Home")
        {
            _currentPage = currentPage;
            _uHelper = uHelper;
            _homePage = _currentPage.AncestorOrSelf(homeDocTypeAlias);
        }

        public List<TargetedItemModel> GetTargetedItemsModel(string ItemsAlias = "targetedItems", string ItemImageAlias = "targetedItemImage", string ItemPageAlias = "targetedItemPage",
                                                string ItemNameAlias = "targetedItemName", string ItemDescriptionAlias = "targetedItemDescription")
        {
            List<TargetedItemModel> model = new List<TargetedItemModel>();

            var targetedItems = _homePage.Value<IEnumerable<IPublishedElement>>(ItemsAlias);

            foreach (var item in targetedItems)
            {
                int imageId = item.Value<IPublishedContent>(ItemImageAlias).Id;

                var mediaItem = _uHelper.Media(imageId);
                string imageUrl = mediaItem.Url();

                int pageId = item.Value<IPublishedContent>(ItemPageAlias).Id;

                IPublishedContent linkedToPage = _uHelper.Content(pageId);
                string linkUrl = linkedToPage.Url();

                string name = item.Value<string>(ItemNameAlias);
                string category = item.Value<string>(ItemDescriptionAlias);

                model.Add(new TargetedItemModel(name, category, imageUrl, linkUrl));
            }

            return model;
        }

        public ServicesModel GetServicesModel(string TitleAlias = "servicesTitle", string SubtitleAlias = "servicesSubtitle", string ListAlias = "servicesList",
                             string ServiceTitleAlias = "serviceTitle", string ServiceIntroductionAlias = "serviceIntroduction", string IconClassAlias = "serviceIconClass")
        {
            string title = _homePage.GetProperty(TitleAlias).GetValue().ToString();
            string subtitle = _homePage.GetProperty(SubtitleAlias).GetValue().ToString();
            var servicesList = _homePage.Value<IEnumerable<IPublishedElement>>(ListAlias);

            List<ServiceItemModel> services = new List<ServiceItemModel>();

            if (servicesList != null)
            {
                foreach (var item in servicesList.Take(_MaxServices))
                {
                    string serviceTitle = item.Value<string>(ServiceTitleAlias);
                    string serviceIntroduction = item.Value<string>(ServiceIntroductionAlias);
                    string serviceIconClass = item.Value<string>(IconClassAlias);

                    services.Add(new ServiceItemModel(serviceTitle, serviceIntroduction, serviceIconClass));
                }
            }
            ServicesModel model = new ServicesModel(title, subtitle, services);

            return model;
        }

        // Currently not used - logic inside the View
        public List<SponsorItemModel> GetSponsorItemsModel(string ItemsAlias = "footerSponsorItems", string ItemImageAlias = "footerSponsorImage", string ItemLinkAlias = "footerSponsorLink")
        {
            List<SponsorItemModel> model = new List<SponsorItemModel>();

            var sponsorItems = _homePage.Value<IEnumerable<IPublishedElement>>(ItemsAlias);

            foreach(var item in sponsorItems)
            {
                int imageId = item.Value<IPublishedContent>(ItemImageAlias).Id;
                var mediaItem = _uHelper.Media(imageId);
                string imageUrl = mediaItem.Url();

                var link = item.Value<Link>(ItemLinkAlias);
                model.Add(new SponsorItemModel(imageUrl, link));
            }
            return model;
        }

        public ServicesMainModel GetServicesMainModel(string sectionAlias = "servicesMainSection", string itemHeaderAlias = "itemHeader", 
                                 string itemIntroAlias = "itemIntroduction", string itemIconAlias = "itemIconClass", string itemLinkAlias = "itemLink")
        {
            ServicesMainModel model = new ServicesMainModel(new List<ServicesMainItemModel>());

            IPublishedContent servicesPage = _homePage.Children.Where(x => x.ContentType.Alias == SERVICES_PAGE_DOCTYPE_ALIAS).FirstOrDefault();

            var mainItems = servicesPage.Value<IEnumerable<IPublishedElement>>(sectionAlias);

            foreach (var item in mainItems)
            {
                string header = item.GetProperty(itemHeaderAlias).GetValue().ToString();
                string intro = item.GetProperty(itemIntroAlias).GetValue().ToString();
                string icon = item.GetProperty(itemIconAlias).GetValue().ToString();
                string link = item.Value<Link>(itemLinkAlias).Url;

                model.ServicesItems.Add(new ServicesMainItemModel(header, intro, link, icon));
            }
            return model;
        }

        public ServicesSidebarModel GetServicesSidebarModel(string sidebarSectionAlias = "servicesSidebarSection", string sidebarTitleAlias = "servicesSidebarTitle",
                                                            string itemTextAlias = "listItemText", string itemLinkAlias = "listItemLink")
        {
            ServicesSidebarModel model = new ServicesSidebarModel("", new List<ServicesSidebarItemModel>());

            IPublishedContent servicesPage = _homePage.Children.Where(x => x.ContentType.Alias == SERVICES_PAGE_DOCTYPE_ALIAS).FirstOrDefault();

            model.SidebarTitle = servicesPage.GetProperty(sidebarTitleAlias).GetValue().ToString();
            var sidebarItems = servicesPage.Value<IEnumerable<IPublishedElement>>(sidebarSectionAlias);

            foreach (var item in sidebarItems)
            {
                string text = item.GetProperty(itemTextAlias).GetValue().ToString();
                string link = item.Value<Link>(itemLinkAlias).Url;

                model.SidebarItems.Add(new ServicesSidebarItemModel(text, link));
            }

            return model;
        }
    }
}
