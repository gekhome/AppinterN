using System;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace Appintern.Core.Composing
{
    /// <summary>
    ///  Source: 3 parts
    ///  https://justnik.me/blog/creating-a-public-profile-page-for-members-in-umbraco-part-2
    /// 
    /// We need 8 composers, one for each member type as we have 'Students', 'Graduates'
    /// and we do not use the member type 'Member'
    /// </summary>
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class RegisterMemberProfileRouteComposer : ComponentComposer<RegisterMemberProfileRouteComponent>
    { }

    public class RegisterMemberProfileRouteComponent : IComponent
    {
        public void Initialize()
        {
            RouteTable.Routes.MapUmbracoRoute("ProfileMemberRoute", "members/{memberAlias}", new
            {
                controller = "Members",
                action = "Profile",
                memberAlias = UrlParameter.Optional
            }, new UmbracoVirtualNodeByUrlRouteHandler("/members"));

            RouteTable.Routes.MapUmbracoRoute("ProfileStudentRoute", "students/{memberAlias}", new
            {
                controller = "Students",
                action = "Profile",
                memberAlias = UrlParameter.Optional
            }, new UmbracoVirtualNodeByUrlRouteHandler("/students"));

            RouteTable.Routes.MapUmbracoRoute("ProfileGraduateRoute", "graduates/{memberAlias}", new
            {
                controller = "Graduates",
                action = "Profile",
                memberAlias = UrlParameter.Optional
            }, new UmbracoVirtualNodeByUrlRouteHandler("/graduates"));

            RouteTable.Routes.MapUmbracoRoute("ProfileAmbassadorRoute", "ambassadors/{memberAlias}", new
            {
                controller = "Ambassadors",
                action = "Profile",
                memberAlias = UrlParameter.Optional
            }, new UmbracoVirtualNodeByUrlRouteHandler("/ambassadors"));

            RouteTable.Routes.MapUmbracoRoute("ProfileEmployerRoute", "employers/{memberAlias}", new
            {
                controller = "Employers",
                action = "Profile",
                memberAlias = UrlParameter.Optional
            }, new UmbracoVirtualNodeByUrlRouteHandler("/employers"));

            RouteTable.Routes.MapUmbracoRoute("ProfileLiaisonRoute", "liaisons/{memberAlias}", new
            {
                controller = "Liaisons",
                action = "Profile",
                memberAlias = UrlParameter.Optional
            }, new UmbracoVirtualNodeByUrlRouteHandler("/liaisons"));

            RouteTable.Routes.MapUmbracoRoute("ProfileOrganizationRoute", "organizations/{memberAlias}", new
            {
                controller = "Organizations",
                action = "Profile",
                memberAlias = UrlParameter.Optional
            }, new UmbracoVirtualNodeByUrlRouteHandler("/organizations"));

            RouteTable.Routes.MapUmbracoRoute("ProfileSchoolRoute", "schools/{memberAlias}", new
            {
                controller = "Schools",
                action = "Profile",
                memberAlias = UrlParameter.Optional
            }, new UmbracoVirtualNodeByUrlRouteHandler("/schools"));

            RouteTable.Routes.MapUmbracoRoute("ProfileTeacherRoute", "teachers/{memberAlias}", new
            {
                controller = "Teachers",
                action = "Profile",
                memberAlias = UrlParameter.Optional
            }, new UmbracoVirtualNodeByUrlRouteHandler("/teachers"));

        }

        public class UmbracoVirtualNodeByUrlRouteHandler : UmbracoVirtualNodeRouteHandler
        {
            private readonly string url;

            public UmbracoVirtualNodeByUrlRouteHandler(string url)
            {
                if (string.IsNullOrWhiteSpace(url))
                {
                    throw new ArgumentException($"'{nameof(url)}' cannot be null or whitespace", nameof(url));
                }

                this.url = url;
            }
            protected override IPublishedContent FindContent(RequestContext requestContext, UmbracoContext umbracoContext)
            {
                return umbracoContext.Content.GetByRoute(url);
            }
        }

        public void Terminate()
        {
            // Nothing to terminate
        }

    }

}