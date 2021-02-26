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
    public class ArticleService : IArticleService
    {
        public IPublishedContent GetArticleListPage(IPublishedContent siteRoot)
        {
            return siteRoot.Descendants().Where(x => x.ContentType.Alias == "articleList").FirstOrDefault();
        }

        public IEnumerable<IPublishedContent> GetLatestArticles(IPublishedContent siteRoot)
        {
            var articleList = GetArticleListPage(siteRoot);

            var articles = articleList.Descendants().Where(x => x.ContentType.Alias == "article" && x.IsVisible()).OrderByDescending(y => y.Value<DateTime>(alias: "articleDate"));

            return articles;
        }

        public ArticleResultSet GetLatestArticles(IPublishedContent currentContentItem, HttpRequestBase request)
        {
            var siteRoot = currentContentItem.Root();

            var articleList = GetArticleListPage(siteRoot);
            var articles = articleList.Descendants().Where(x => x.ContentType.Alias == "article" && x.IsVisible()).OrderByDescending(y => y.Value<DateTime>(alias: "articleDate"));

            var isArticleListPage = articleList.Id == currentContentItem.Id;
            var fallbackPageSize = isArticleListPage ? 6 : 3;

            var pageNumber = QueryStringHelper.GetIntFromQueryString(request, "page", 1);
            var pageSize = QueryStringHelper.GetIntFromQueryString(request, "size", fallbackPageSize);

            var hasArticles = articles != null && articles.Any();

            var pageOfArticles = hasArticles ? articles.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList() : Enumerable.Empty<IPublishedContent>();

            var totalItemCount = hasArticles ? articles.Count() : 0;

            var pageCount = totalItemCount > 0 ? Math.Ceiling((double)totalItemCount / pageSize) : 1;

            var resultSet = new ArticleResultSet()
            {
                PageCount = pageCount,
                PageNumber = pageNumber,
                PageSize = pageSize,
                Results = pageOfArticles,
                IsArticleListPage = isArticleListPage,
                Url = articleList.Url()
            };

            return resultSet;
        }
    }
}
