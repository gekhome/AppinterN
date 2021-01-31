using Appintern.Core.Models;
using System.Collections.Generic;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace Appintern.Core.Services
{
    public interface IApprenticeshipService
    {
        IPublishedContent GetApprenticeshipListPage(IPublishedContent siteRoot);

        IEnumerable<IPublishedContent> GetLatestApprenticeships(IPublishedContent siteRoot);

        ApprenticeshipResultSet GetLatestApprenticeships(IPublishedContent currentContentItem, HttpRequestBase request);

    }
}
