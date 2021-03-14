using Appintern.Core.Helpers;
using Appintern.Core.Services;
using Appintern.Web.DAL;
using Appintern.Web.Library;
using Appintern.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Logging;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;
using CM = Umbraco.Web.PublishedModels;

namespace Appintern.Web.Controllers
{
    public class UserController : SurfaceController
    {
        private readonly AppinternWorksEntities db = new AppinternWorksEntities();
        private readonly Utilities utilities = new Utilities();

        private readonly ILogger _logger;
        private readonly IDataTypeValueService _dataTypeValueService;
        private readonly IMemberService _memberService;

        public UserController(ILogger logger, IDataTypeValueService dataTypeValueService, IMemberService memberService)
        {
            _logger = logger;
            _dataTypeValueService = dataTypeValueService;
            _memberService = memberService;
        }

        private string GetViewPath(string name)
        {
            return $"~/Views/Partials/Member/{name}.cshtml";
        }

        public ActionResult RenderSignUp()
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> categories =_dataTypeValueService.GetItemsFromValueListDataType("Dropdown Member Categories", null);

            SignUpModel model = new SignUpModel()
            {
                Name = "",
                Email = "",
                Username = "",
                Password = "",
                ConfirmPassword = "",
                MemberCategories = categories
            };

            return PartialView(GetViewPath("_MemberSignUp"), model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitSignUp(SignUpModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (!MemberHelper.MemberExists(model.Email, model.Username))
                {
                    try
                    {
                        // Dropdwon item is the string value
                        string memberType = utilities.GetMemberType(model.MemberCategory);
                        string memberGroup = utilities.GetMemberGroup(model.MemberCategory);

                        int memberId = MemberHelper.CreateCustomMember(model.Username, model.Name, model.Email, model.Password, memberType, memberGroup);

                        if (memberId > 0)
                        {
                            string memberUrl = utilities.SetMemberUrlSlug(memberId, memberType);
                            return Redirect("/login/");
                        }
                        else
                            return CurrentUmbracoPage();
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(typeof(UserController), ex, "Error registering new member.");
                        ModelState.AddModelError("", ex.Message);
                        return CurrentUmbracoPage();
                    }
                }
                ModelState.AddModelError("", "This email or username is already used. Registration cancelled.");
            }
            return CurrentUmbracoPage();
        }

        public ActionResult RenderLogin()
        {
            return PartialView(GetViewPath("_MemberLogin"), new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitLogin(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, createPersistentCookie: true);

                    UrlHelper myHelper = new UrlHelper(HttpContext.Request.RequestContext);

                    if (myHelper.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return Redirect("~/");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The username or password provided is incorrect.");
                }
            }
            return CurrentUmbracoPage();
        }

        public ActionResult RenderLogout()
        {
            return PartialView(GetViewPath("_MemberLogout"), null);
        }

        [HttpPost]
        public ActionResult SubmitLogout()
        {
            TempData.Clear();
            Session.Clear();
            FormsAuthentication.SignOut();

            return Redirect("~/");
        }


        #region UTILITIES

        public IMember GetMemberFromUser(MembershipUser user)
        {
            return user != null ? _memberService.GetByUsername(user.UserName) : null;
        }

        public bool ValidFileExtension(string extension)
        {
            string[] extensions = { "PNG", "JPEG", "JPG", "GIF", "WEBP", "TIFF" };

            List<string> valid_extensions = new List<string>(extensions);

            if (valid_extensions.Contains(extension.ToUpper()))
                return true;
            return false;
        }

        #endregion
    }
}