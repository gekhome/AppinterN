using Appintern.Core.Services;
using Appintern.Web.DAL;
using Appintern.Web.Library;
using Appintern.Web.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        private readonly IDataTypeValueService _dataTypeValueService;
        private readonly IMediaUploadService _mediaUploadService;

        private readonly DataAccess dataAccess = new DataAccess();
        ServiceContext _serviceContext = Current.Services;

        private const string HOMEPAGE_DOCTYPE_ALIAS = "home";
        private const string APPR_LIST_DOCTYPE_ALIAS = "apprenticeshipList";
        private const string ARTICLELIST_DOCTYPE_ALIAS = "articleList";

        private const int HOME_PAGE_ID = 1080;
        private const int DASHBOARD_PAGE_ID = 1189;
        private const int TASKS_MAIN_PAGE_ID = 1539;
        private const int MEDIA_NEWS_FOLDER_ID = 1134;
        private const int APPRENTICESHIP_MAIN_PAGE_ID = 1529;

        public TasksMemberController(ILogger logger, IDataTypeValueService dataTypeValueService, IMediaUploadService mediaUploadService)
        {
            _logger = logger;
            _dataTypeValueService = dataTypeValueService;
            _mediaUploadService = mediaUploadService;

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

        #region ARTICLES PUBLISH GRID

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
            var contentService = Services.ContentService;
            var article = contentService.GetById(model.ArticleId);

            contentService.Unpublish(article);
            contentService.Delete(article); // here content getting deleted
            contentService.EmptyRecycleBin(userId:-1);

            return Json(new[] { model }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }

        public void UpdateArticleGridFields(IContent article, UmbracoArticleModel model)
        {
            loggedMember = GetLoggedMember();
            var memberUdi = Current.Services.MemberService.GetById(loggedMember.MemberId).GetUdi();

            article.Name = model.ArticleName;
            article.SetValue(Article.GetModelPropertyType(x => x.Title).Alias, model.Title);
            article.SetValue(Article.GetModelPropertyType(x => x.AuthorName).Alias, model.AuthorName);
            article.SetValue(Article.GetModelPropertyType(x => x.ArticleDate).Alias, model.ArticleDate);
            article.SetValue(Article.GetModelPropertyType(x => x.MetaName).Alias, model.MetaName);
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
                        Description = (HtmlString)description,
                        Country = country,
                        MemberId = memberId,
                        MetaName = metaName,
                        MetaDescription = metaDescription,
                        MetaKeywords = utilities.ConcatenateStringArray(metaKeywords),
                        SelectedCategories = categories
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

        #region ARTICLE DETAILS FORM

        public ActionResult MemberArticleDetail(int articleId)
        {
            UmbracoArticleModel model = GetArticleRecord(articleId);
            model.Countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);

            return PartialView(GetTasksViewPath("_ArticleDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitArticleDetails(UmbracoArticleModel model)
        {
            var contentService = Services.ContentService;
            var article = contentService.GetById(model.ArticleId);

            if (model != null && ModelState.IsValid)
            {
                UpdateArticleDetails(article, model);
                contentService.SaveAndPublish(article);
            }

            // required to set the sources again on post
            model.Countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
            model.Categories = utilities.GetContentCategories();

            ViewData["successMessage"] = "Detail data were successfully saved at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);

            return PartialView(GetTasksViewPath("_ArticleDetail"), model);
        }

        public UmbracoArticleModel GetArticleRecord(int articleId)
        {
            var contentService = Services.ContentService;
            var article = contentService.GetById(articleId);

            JArray rawCategories = (JArray)JsonConvert.DeserializeObject(article.GetValue("category").ToString());
            JArray rawKeywords = (JArray)JsonConvert.DeserializeObject(article.GetValue("metaKeywords").ToString());
            JArray rawCountry = (JArray)JsonConvert.DeserializeObject(article.GetValue("country").ToString());

            string[] taggedCategories = rawCategories.ToObject<string[]>();
            string[] taggedKeywords = rawKeywords.ToObject<string[]>();
            string[] countries = rawCountry.ToObject<string[]>();

            string keywords = utilities.ConcatenateStringArray(taggedKeywords);
            string country = countries[0];

            UmbracoArticleModel model = new UmbracoArticleModel()
            {
                ArticleId = article.Id,
                ArticleName = article.Name,
                ArticleDate = article.GetValue("articleDate") != null ? (DateTime)article.GetValue("articleDate") : DateTime.Now.Date,
                AuthorName = article.GetValue("authorName") != null ? article.GetValue("authorName").ToString() : "",
                Title = article.GetValue("title") != null ? article.GetValue("title").ToString() : "",
                MetaName = article.GetValue("metaName") != null ? article.GetValue("metaName").ToString() : "",
                MetaDescription = article.GetValue("metaDescription") != null ? article.GetValue("metaDescription").ToString() : "",
                Country = country,
                MetaKeywords = keywords,
                SelectedCategories = taggedCategories,
                Categories = utilities.GetContentCategories()
            };

            return model;
        }

        public void UpdateArticleDetails(IContent article, UmbracoArticleModel model)
        {
            List<string> keywords = model.MetaKeywords.Split(',').ToList();
            List<string> categories = model.SelectedCategories.ToList();

            var country = JsonConvert.SerializeObject(new[] { model.Country });

            article.Name = model.ArticleName;
            article.SetValue(Article.GetModelPropertyType(x => x.Title).Alias, model.Title);
            article.SetValue(Article.GetModelPropertyType(x => x.AuthorName).Alias, model.AuthorName);
            article.SetValue(Article.GetModelPropertyType(x => x.ArticleDate).Alias, model.ArticleDate);
            article.SetValue(Article.GetModelPropertyType(x => x.MetaName).Alias, model.MetaName);
            article.SetValue(Article.GetModelPropertyType(x => x.MetaDescription).Alias, model.MetaDescription);
            article.SetValue(Article.GetModelPropertyType(x => x.Category).Alias, JsonConvert.SerializeObject(categories));
            article.SetValue(Article.GetModelPropertyType(x => x.MetaKeywords).Alias, JsonConvert.SerializeObject(keywords));
            article.SetValue(Article.GetModelPropertyType(x => x.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
        }

        #endregion

        #region ARTICLE IMAGE FORM

        public ActionResult MemberArticleImage(int articleId)
        {
            var contentService = Services.ContentService;
            var article = contentService.GetById(articleId);
            ArticleImageModel model = new ArticleImageModel();

            string mediaUdi = article.GetValue("mainImage") != null ? article.GetValue("mainImage").ToString() : "";

            if (!string.IsNullOrEmpty(mediaUdi))
            {
                Udi imageUdi = Udi.Parse(mediaUdi);
                model.ImageUrl = Umbraco.PublishedContent(imageUdi).Url();
            }
            model.ArticleId = articleId;

            return PartialView(GetTasksViewPath("_ArticleImage"), model);
        }

        public ActionResult SubmitArticleImage(ArticleImageModel model)
        {
            var contentService = Services.ContentService;
            var article = contentService.GetById(model.ArticleId);

            if (model.MainImage != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.MainImage.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_ArticleImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.MainImage, MEDIA_NEWS_FOLDER_ID, "Image");
                article.SetValue(Article.GetModelPropertyType(x => x.MainImage).Alias, imageUdi);

                contentService.SaveAndPublish(article);
                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.MainImage.FileName);
            }

            return PartialView(GetTasksViewPath("_ArticleImage"), model);
        }

        #endregion

        #region ARTICLE RTE CONTENT FORM

        public ActionResult MemberArticleContent(int articleId)
        {
            var contentService = Services.ContentService;
            var article = contentService.GetById(articleId);

            UmbracoArticleModel model = new UmbracoArticleModel();

            model.Description = new HtmlString(article.GetValue("description").ToString());
            model.ArticleId = articleId;

            return PartialView(GetTasksViewPath("_ArticleContent"), model);
        }

        public ActionResult ArticleContentSave(string htmlText, int articleId)
        {
            string msg = "The content of the article was successfully saved.";

            var contentService = Services.ContentService;
            var article = contentService.GetById(articleId);

            UmbracoArticleModel model = new UmbracoArticleModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            // Do this to get rid of the enclosing quotation marks ""
            model.Description = new HtmlString(htmlValue);

            article.SetValue(Article.GetModelPropertyType(x => x.Description).Alias, model.Description);
            contentService.SaveAndPublish(article);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }

        #endregion
    }
}