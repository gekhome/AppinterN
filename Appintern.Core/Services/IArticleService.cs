using Appintern.Core.Models;
using System.Collections.Generic;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace Appintern.Core.Services
{
    public interface IArticleService
    {
        IPublishedContent GetArticleListPage(IPublishedContent siteRoot);

        IEnumerable<IPublishedContent> GetLatestArticles(IPublishedContent siteRoot);

        ArticleResultSet GetLatestArticles(IPublishedContent currentContentItem, HttpRequestBase request);

    }
}
