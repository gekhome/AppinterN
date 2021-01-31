using Appintern.Core.Services;
using Appintern.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Composing;
using Umbraco.Core.Logging;
using Umbraco.Core.Persistence.Querying;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using CM = Umbraco.Web.PublishedModels;

namespace Appintern.Web.Controllers
{
    /// <summary>
    /// Source: 3 parts - this is part3 not working
    /// We have 8 different member types (Student, Graduate, Employer,...)
    /// so we need 8 route hijacking controllers.
    /// Each should be named accordingly, i.e 'StudentsController', 'GraduatesController',...
    /// The member type 'Member' is not used
    /// https://justnik.me/blog/creating-a-public-profile-page-for-members-in-umbraco-part-3
    /// </summary>
    public class TeachersController :    RenderMvcController
    {
        public override ActionResult Index(ContentModel model)
        {
            return base.Index(model);
        }

        /// <summary>
        /// Route hijacking Action for member profile
        /// </summary>
        /// <param name="model"></param>
        /// <param name="memberAlias">unique Url slug for member</param>
        /// <returns>View with model</returns>
        public new ActionResult Profile(ContentModel model, string memberAlias)
        {
            var memberService = Current.Services.MemberService;
            var members = memberService.GetMembersByPropertyValue(CM.Teacher.GetModelPropertyType(p => p.UrlSlug).Alias, memberAlias, StringPropertyMatchType.Exact);

            if (model.Content is CM.Teachers membersNode && members.Count() == 1)
            {
                return View("MemberProfile", membersNode);
            }
            else
                return View("InvalidProfile", model.Content);
        }
    }
}