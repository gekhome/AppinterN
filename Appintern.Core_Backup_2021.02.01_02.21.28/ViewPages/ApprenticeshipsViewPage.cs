using Appintern.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Cache;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;
using Current = Umbraco.Web.Composing.Current;

namespace Appintern.Core.ViewPages
{
    public abstract class ApprenticeshipsViewPage<T> : UmbracoViewPage<T>
    {
        public readonly IApprenticeshipService ApprenticeshipService;

        public ApprenticeshipsViewPage() : this(
            Current.Factory.GetInstance<IApprenticeshipService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
        )
        { }
        public ApprenticeshipsViewPage(IApprenticeshipService apprenticeshipService, ServiceContext services, AppCaches appCaches)
        {
            ApprenticeshipService = apprenticeshipService;
            Services = services;
            AppCaches = appCaches;
        }
    }

    public abstract class ApprenticeshipsViewPage : UmbracoViewPage
    {
        public readonly IApprenticeshipService ApprenticeshipService;
        public ApprenticeshipsViewPage() : this(
            Current.Factory.GetInstance<IApprenticeshipService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
        )
        { }

        public ApprenticeshipsViewPage(IApprenticeshipService apprenticeshipService, ServiceContext services, AppCaches appCaches)
        {
            ApprenticeshipService = apprenticeshipService;
            Services = services;
            AppCaches = appCaches;
        }
    }
}
