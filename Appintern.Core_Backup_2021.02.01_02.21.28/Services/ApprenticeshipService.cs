using Appintern.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Appintern.Core.Helpers;
using Umbraco.Web;

namespace Appintern.Core.Services
{
    public class ApprenticeshipService : IApprenticeshipService
    {
        public IPublishedContent GetApprenticeshipListPage(IPublishedContent siteRoot)
        {
            return siteRoot.Descendants().Where(x => x.ContentType.Alias == "apprenticeshipList").FirstOrDefault();
        }

        public IEnumerable<IPublishedContent> GetLatestApprenticeships(IPublishedContent siteRoot)
        {
            var apprenticeshipList = GetApprenticeshipListPage(siteRoot);

            var apprenticeships = apprenticeshipList.Descendants().Where(x => x.ContentType.Alias == "apprenticeship" && x.IsVisible()).OrderByDescending(y => y.Value<DateTime>(alias: "postDate"));

            return apprenticeships;
        }

        public ApprenticeshipResultSet GetLatestApprenticeships(IPublishedContent currentContentItem, HttpRequestBase request)
        {
            var siteRoot = currentContentItem.Root();

            var apprenticeshipList = GetApprenticeshipListPage(siteRoot);
            var apprenticeships = apprenticeshipList.Descendants().Where(x => x.ContentType.Alias == "apprenticeship" && x.IsVisible()).OrderByDescending(y => y.Value<DateTime>(alias: "postDate"));

            var isApprenticeshipListPage = apprenticeshipList.Id == currentContentItem.Id;
            var fallbackPageSize = isApprenticeshipListPage ? 6 : 3;

            var pageNumber = QueryStringHelper.GetIntFromQueryString(request, "page", 1);
            var pageSize = QueryStringHelper.GetIntFromQueryString(request, "size", fallbackPageSize);

            var hasApprenticeships = apprenticeships != null && apprenticeships.Any();

            var pageOfApprenticeships = hasApprenticeships
                ? apprenticeships.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
                : Enumerable.Empty<IPublishedContent>();

            var totalItemCount = hasApprenticeships ? apprenticeships.Count() : 0;

            var pageCount = totalItemCount > 0 ? Math.Ceiling((double)totalItemCount / pageSize) : 1;

            var resultSet = new ApprenticeshipResultSet()
            {
                PageCount = pageCount,
                PageNumber = pageNumber,
                PageSize = pageSize,
                Results = pageOfApprenticeships,
                IsApprenticeshipListPage = isApprenticeshipListPage,
                Url = apprenticeshipList.Url()
            };

            return resultSet;
        }
    }
}
