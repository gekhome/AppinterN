using Appintern.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Cache;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;
using Current = Umbraco.Web.Composing.Current;

namespace Appintern.Core.ViewPages
{
    public abstract class ArticlesViewPage<T> : UmbracoViewPage<T>
    {
        public readonly IArticleService ArticleService;

        public ArticlesViewPage() : this(
            Current.Factory.GetInstance<IArticleService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
        )
        { }
        public ArticlesViewPage(IArticleService articleService, ServiceContext services, AppCaches appCaches)
        {
            ArticleService = articleService;
            Services = services;
            AppCaches = appCaches;
        }
    }

    public abstract class ArticlesViewPage : UmbracoViewPage
    {
        public readonly IArticleService ArticleService;
        public ArticlesViewPage() : this(
            Current.Factory.GetInstance<IArticleService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
        )
        { }

        public ArticlesViewPage(IArticleService articleService, ServiceContext services, AppCaches appCaches)
        {
            ArticleService = articleService;
            Services = services;
            AppCaches = appCaches;
        }
    }
}
