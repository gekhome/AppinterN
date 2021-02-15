using Appintern.Web.DAL;
using Appintern.Web.DAL.Services;
using Appintern.Web.Library;
using Appintern.Web.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.Composing;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;
using CM = Umbraco.Web.PublishedModels;

namespace Appintern.Web.Controllers
{
    /// <summary>
    /// TELERIK APP BASED ON THE UMBRACO SITE
    /// </summary>
    public class TasksMemberController : SurfaceController
    {
        private readonly AppinternWorksEntities db = new AppinternWorksEntities();
        private readonly Utilities utilities = new Utilities();
        private readonly ILogger _logger;
        private LoggedMemberModel loggedMember;

        private readonly DataAccess dataAccess = new DataAccess();
        ServiceContext _serviceContext = Current.Services;

        private const string HOMEPAGE_DOCTYPE_ALIAS = "home";
        private const string APPR_LIST_DOCTYPE_ALIAS = "apprenticeshipList";
        private const string ARTICLELIST_DOCTYPE_ALIAS = "articleList";

        private const int HOME_PAGE_ID = 1080;
        private const int DASHBOARD_PAGE_ID = 1189;
        private const int TASKS_MAIN_PAGE_ID = 1539;
        private const int APPRENTICESHIP_MAIN_PAGE_ID = 1529;

        public TasksMemberController(ILogger logger)
        {
            _logger = logger;

            // Just testing to have this elsewhere in the project
            loggedMember = GetLoggedMember();
        }

        #region TasksMember Utility Functions 

        private string GetTasksViewPath(string name)
        {
            return $"~/Views/Partials/TasksMember/{name}.cshtml";
        }

        public ActionResult RenderTasksHome()
        {
            return PartialView(GetTasksViewPath("_TasksHome"));
        }

        public ActionResult RenderTasksMain()
        {
            return RedirectToUmbracoPage(TASKS_MAIN_PAGE_ID);
        }

        public ActionResult RenderDashboardHome()
        {
            return RedirectToUmbracoPage(DASHBOARD_PAGE_ID);
        }

        /// <summary>
        /// Gets current logged in Member. Returns Id, Name, and Type
        /// </summary>
        /// <returns>model with Id, Name and member Type</returns>
        public LoggedMemberModel GetLoggedMember()
        {
            IPublishedContent loggedMember = Members.GetCurrentMember();
            string memberType = loggedMember.ContentType.Alias.ToString();

            int memberId = loggedMember.Id;
            string memberName = loggedMember.Name;

            LoggedMemberModel model = new LoggedMemberModel()
            {
                MemberId = memberId,
                MemberName = memberName,
                MemberType = memberType
            };
            return model;
        }

        #endregion

        #region ARTICLES PUBLISHING GRID

        public ActionResult RenderMemberArticles()
        {
            return PartialView(GetTasksViewPath("_MemberArticles"));
        }

        public ActionResult UmbracoArticle_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetUmbracoArticles().OrderBy(p => p.ArticleName);

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UmbracoArticle_Create([DataSourceRequest] DataSourceRequest request, UmbracoArticleModel model)
        {
            IPublishedContent homePage = Umbraco.ContentAtRoot().Where(f => f.IsDocumentType(HOMEPAGE_DOCTYPE_ALIAS)).FirstOrDefault();
            IPublishedContent articlesList = homePage.Descendants().Where(x => x.IsDocumentType(ARTICLELIST_DOCTYPE_ALIAS)).FirstOrDefault();
            var parentId = articlesList.Id;

            var contentService = Services.ContentService;
            
            if (model != null && ModelState.IsValid)
            {
                var article = contentService.Create(model.ArticleName, parentId, Article.ModelTypeAlias);

                UpdateArticleGridFields(article, model);
                contentService.SaveAndPublish(article);
                //model.ArticleId = article.Id;
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UmbracoArticle_Update([DataSourceRequest] DataSourceRequest request, UmbracoArticleModel model)
        {
            var contentService = Services.ContentService;
            var article = contentService.GetById(model.ArticleId);

            if (model != null && ModelState.IsValid)
            {
                UpdateArticleGridFields(article, model);
                contentService.SaveAndPublish(article);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UmbracoArticle_Destroy([DataSourceRequest] DataSourceRequest request, UmbracoArticleModel model)
        {

            return Json(new[] { model }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }

        public void UpdateArticleGridFields(IContent article, UmbracoArticleModel model)
        {
            loggedMember = GetLoggedMember();
            var memberUdi = Current.Services.MemberService.GetById(loggedMember.MemberId).GetUdi();

            List<string> categories = model.Categories.Split(',').ToList();
            List<string> keywords = model.MetaKeywords.Split(',').ToList();

            article.SetValue(Article.GetModelPropertyType(x => x.Title).Alias, model.Title);
            article.SetValue(Article.GetModelPropertyType(x => x.AuthorName).Alias, model.AuthorName);
            article.SetValue(Article.GetModelPropertyType(x => x.ArticleDate).Alias, model.ArticleDate);
            article.SetValue(Article.GetModelPropertyType(x => x.MetaDescription).Alias, model.MetaDescription);
            article.SetValue(Article.GetModelPropertyType(x => x.Category).Alias, JsonConvert.SerializeObject(categories));
            article.SetValue(Article.GetModelPropertyType(x => x.MetaKeywords).Alias, JsonConvert.SerializeObject(keywords));
            article.SetValue(Article.GetModelPropertyType(x => x.ArticleMember).Alias, memberUdi);
        }

        public List<UmbracoArticleModel> GetUmbracoArticles()
        {
            List<UmbracoArticleModel> model = new List<UmbracoArticleModel>();

            loggedMember = GetLoggedMember();

            IPublishedContent homePage = Umbraco.ContentAtRoot().Where(f => f.IsDocumentType(HOMEPAGE_DOCTYPE_ALIAS)).FirstOrDefault();
            IPublishedContent articlesList = homePage.Descendants().Where(x => x.IsDocumentType(ARTICLELIST_DOCTYPE_ALIAS)).FirstOrDefault();

            foreach (IPublishedContent item in articlesList.Children.OrderBy(x => x.Name))
            {
                // switch case here for member type
                int memberId = GetMemberTypeId(item, loggedMember.MemberType);

                if (memberId == loggedMember.MemberId)
                {
                    int articleId = item.Id;
                    string name = item.Name;
                    DateTime articleDate = (DateTime)item.GetProperty("articleDate").GetValue();
                    string authorName = item.GetProperty("authorName").GetValue().ToString();
                    string title = item.GetProperty("title").GetValue().ToString();
                    var description = item.GetProperty("description").GetValue();
                    string country = item.GetProperty("country").GetValue().ToString();
                    string metaName = item.GetProperty("metaName").GetValue().ToString();
                    string metaDescription = item.GetProperty("metaDescription").GetValue().ToString();
                    string[] metaKeywords = (string[])item.GetProperty("metaKeywords").GetValue();
                    string[] categories = (string[])item.GetProperty("category").GetValue();

                    model.Add(new UmbracoArticleModel()
                    {
                        ArticleId = articleId,
                        ArticleName = name,
                        ArticleDate = articleDate,
                        AuthorName = authorName,
                        Title = title,
                        Description = (IHtmlString)description,
                        Country = country,
                        MemberId = memberId,
                        MetaName = metaName,
                        MetaDescription = metaDescription,
                        MetaKeywords = utilities.ConcatenateStringArray(metaKeywords),
                        Categories = utilities.ConcatenateStringArray(categories)
                    });
                }
            }
            return model;
        }

        public int GetMemberTypeId(IPublishedContent item, string memberType)
        {
            if (memberType == "ambassador")
            {
                if (item.GetProperty("articleMember").GetValue() is Ambassador articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "employer")
            {
                if (item.GetProperty("articleMember").GetValue() is Employer articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "liaison")
            {
                if (item.GetProperty("articleMember").GetValue() is Liaison articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "organization")
            {
                if (item.GetProperty("articleMember").GetValue() is Organization articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "school")
            {
                if (item.GetProperty("articleMember").GetValue() is School articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "teacher")
            {
                if (item.GetProperty("articleMember").GetValue() is Teacher articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "Member")
            {
                if (item.GetProperty("articleMember").GetValue() is CM.Member articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else
                return 0;
        }

        #endregion

        #region ARTICLE EDIT FORM

        public ActionResult MemberArticleEdit(int articleId)
        {
            UmbracoArticleModel model = new UmbracoArticleModel();
            model.ArticleId = articleId;

            return PartialView(GetTasksViewPath("_MemberArticleEdit"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitArticleForm(UmbracoArticleModel model)
        {
            ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);

            return PartialView(GetTasksViewPath("_MemberArticleEdit"), model);
            //return RedirectToCurrentUmbracoPage(); // does not work for simple MVC form
        }

        #endregion
    }
}