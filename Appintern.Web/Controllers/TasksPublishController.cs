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
    public class TasksPublishController : SurfaceController
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
        private const int DASHBOARD_PAGE_ID = 1189;     // Admin Dashboard page
        private const int TASKS_MAIN_PAGE_ID = 1539;    // Member Dashboard page
        private const int MEDIA_NEWS_FOLDER_ID = 1134;
        private const int PAGE_IMAGES_FOLDER_ID = 1102; // stores page images for apprenticeships and other pages
        private const int APPRENTICESHIP_MAIN_PAGE_ID = 1529;

        public TasksPublishController(ILogger logger, IDataTypeValueService dataTypeValueService, IMediaUploadService mediaUploadService)
        {
            _logger = logger;
            _dataTypeValueService = dataTypeValueService;
            _mediaUploadService = mediaUploadService;

            loggedMember = GetLoggedMember();
        }

        #region TasksMember Utility Functions 

        private string GetTasksViewPath(string name)
        {
            return $"~/Views/Partials/TasksPublish/{name}.cshtml";
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

        #region MEMBER ARTICLES

        #region ARTICLES PUBLISH GRID

        public ActionResult RenderMemberArticles()
        {
            string memberType = loggedMember.MemberType;

            bool deny = memberType == "graduate" || memberType == "student" || memberType == "teacher" || memberType == "school";

            if (deny)
                return RedirectToAction("AccessDenied", "TasksPublish");

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
                model.ArticleId = article.Id;
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
            UmbracoArticleModel model = GetArticleContent(articleId);

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

        public UmbracoArticleModel GetArticleContent(int articleId)
        {
            var contentService = Services.ContentService;
            var article = contentService.GetById(articleId);

            JArray rawCategories = article.GetValue("category") != null ? (JArray)JsonConvert.DeserializeObject(article.GetValue("category").ToString()) : new JArray();
            JArray rawKeywords = article.GetValue("metaKeywords") != null ? (JArray)JsonConvert.DeserializeObject(article.GetValue("metaKeywords").ToString()) : new JArray();
            JArray rawCountry = article.GetValue("country") != null ? (JArray)JsonConvert.DeserializeObject(article.GetValue("country").ToString()) : new JArray();

            string[] taggedCategories = rawCategories.ToObject<string[]>();
            string[] taggedKeywords = rawKeywords.ToObject<string[]>();
            string[] countries = rawCountry.ToObject<string[]>();

            string keywords = utilities.ConcatenateStringArray(taggedKeywords);
            string country = countries.Length > 0 ? countries[0] : "";

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
                Categories = utilities.GetContentCategories(),
                Countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null)

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

                string mediaUdi = article.GetValue("mainImage") != null ? article.GetValue("mainImage").ToString() : "";
                if (!string.IsNullOrEmpty(mediaUdi))
                {
                    Udi _imageUdi = Udi.Parse(mediaUdi);
                    model.ImageUrl = Umbraco.PublishedContent(_imageUdi).Url();
                }
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

        #endregion

        #region MEMBER APPRENTICESHIPS

        #region APPRENTICESHIPS PUBLISH GRID

        public ActionResult RenderMemberApprenticeships()
        {
            string memberType = loggedMember.MemberType;
            bool deny = memberType == "graduate" || memberType == "student" || memberType == "teacher" || memberType == "school";

            if (deny)
                return RedirectToAction("AccessDenied", "TasksPublish");

            return PartialView(GetTasksViewPath("_MemberApprenticeships"));
        }

        public ActionResult Apprenticeship_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetUmbracoApprenticeships().OrderByDescending(x => x.PostDate);

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Apprenticeship_Create([DataSourceRequest] DataSourceRequest request, UmbracoApprenticeshipModel model)
        {
            IPublishedContent homePage = Umbraco.ContentAtRoot().Where(f => f.IsDocumentType(HOMEPAGE_DOCTYPE_ALIAS)).FirstOrDefault();
            IPublishedContent apprenticeshipList = homePage.Descendants().Where(x => x.IsDocumentType(APPR_LIST_DOCTYPE_ALIAS)).FirstOrDefault();
            var parentId = apprenticeshipList.Id;

            var contentService = Services.ContentService;

            if (model != null && ModelState.IsValid)
            {
                var content = contentService.Create(model.ApprenticeshipName, parentId, Apprenticeship.ModelTypeAlias);

                UpdateApprenticeshipGridFields(content, model);
                contentService.SaveAndPublish(content);
                model.ApprenticeshipId = content.Id;
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Apprenticeship_Update([DataSourceRequest] DataSourceRequest request, UmbracoApprenticeshipModel model)
        {
            var contentService = Services.ContentService;
            var content = contentService.GetById(model.ApprenticeshipId);

            if (model != null && ModelState.IsValid)
            {
                UpdateApprenticeshipGridFields(content, model);
                contentService.SaveAndPublish(content);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Apprenticeship_Destroy([DataSourceRequest] DataSourceRequest request, UmbracoApprenticeshipModel model)
        {
            var contentService = Services.ContentService;
            var content = contentService.GetById(model.ApprenticeshipId);

            contentService.Unpublish(content);
            contentService.Delete(content);     // here content gets deleted
            contentService.EmptyRecycleBin(userId: -1);

            return Json(new[] { model }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }

        public void UpdateApprenticeshipGridFields(IContent content, UmbracoApprenticeshipModel model)
        {
            loggedMember = GetLoggedMember();
            var memberUdi = Current.Services.MemberService.GetById(loggedMember.MemberId).GetUdi();

            content.Name = model.ApprenticeshipName;
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Title).Alias, model.Title);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.PostDate).Alias, model.PostDate);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.StartDate).Alias, model.StartDate);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.EndDate).Alias, model.EndDate);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.MetaName).Alias, model.MetaName);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Employer).Alias, memberUdi);
        }

        public List<UmbracoApprenticeshipModel> GetUmbracoApprenticeships()
        {
            List<UmbracoApprenticeshipModel> model = new List<UmbracoApprenticeshipModel>();

            loggedMember = GetLoggedMember();

            IPublishedContent homePage = Umbraco.ContentAtRoot().Where(f => f.IsDocumentType(HOMEPAGE_DOCTYPE_ALIAS)).FirstOrDefault();
            IPublishedContent apprenticeshipList = homePage.Descendants().Where(x => x.IsDocumentType(APPR_LIST_DOCTYPE_ALIAS)).FirstOrDefault();

            foreach (IPublishedContent item in apprenticeshipList.Children.OrderBy(x => x.Name))
            {
                // switch case here for member type
                int memberId = GetEmployerTypeId(item, loggedMember.MemberType);

                if (memberId == loggedMember.MemberId)
                {
                    int apprenticeshipId = item.Id;
                    string apprenticeshipName = item.Name;
                    DateTime postDate = (DateTime)item.GetProperty("postDate").GetValue();
                    DateTime startDate = (DateTime)item.GetProperty("startDate").GetValue();
                    DateTime endDate = (DateTime)item.GetProperty("endDate").GetValue();
                    string title = item.GetProperty("title").GetValue().ToString();
                    string country = item.GetProperty("country").GetValue().ToString();
                    string metaName = item.GetProperty("metaName").GetValue().ToString();
                    string metaDescription = item.GetProperty("metaDescription").GetValue().ToString();
                    string[] metaKeywords = (string[])item.GetProperty("metaKeywords").GetValue();
                    string[] categories = (string[])item.GetProperty("category").GetValue();
                    string jobSector = item.GetProperty("jobSector").GetValue().ToString();

                    model.Add(new UmbracoApprenticeshipModel()
                    {
                        ApprenticeshipId = apprenticeshipId,
                        ApprenticeshipName = apprenticeshipName,
                        PostDate = postDate,
                        StartDate = startDate,
                        EndDate = endDate,
                        Title = title,
                        Country = country,
                        MemberId = memberId,
                        MetaName = metaName,
                        MetaDescription = metaDescription,
                        MetaKeywords = utilities.ConcatenateStringArray(metaKeywords),
                        JobSector = jobSector,
                        SelectedCategories = categories
                    });
                }
            }
            return model;
        }

        public int GetEmployerTypeId(IPublishedContent item, string memberType)
        {
            if (memberType == "ambassador")
            {
                if (item.GetProperty("employer").GetValue() is Ambassador articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "employer")
            {
                if (item.GetProperty("employer").GetValue() is Employer articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "liaison")
            {
                if (item.GetProperty("employer").GetValue() is Liaison articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "organization")
            {
                if (item.GetProperty("employer").GetValue() is Organization articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "Member")
            {
                if (item.GetProperty("employer").GetValue() is CM.Member articleMember)
                    return articleMember.Id;
                else
                    return 0;
            }
            else
                return 0;
        }

        #endregion

        #region APPRENTICESHIP DETAILS FORM

        public ActionResult ApprenticeshipDetail(int apprenticeshipId)
        {
            UmbracoApprenticeshipModel model = GetApprenticeshipContent(apprenticeshipId);

            return PartialView(GetTasksViewPath("_ApprenticeshipDetail"), model);
        }

        public UmbracoApprenticeshipModel GetApprenticeshipContent(int apprenticeshipId)
        {
            var contentService = Services.ContentService;
            var content = contentService.GetById(apprenticeshipId);

            JArray rawCategories = content.GetValue("category") != null ? (JArray)JsonConvert.DeserializeObject(content.GetValue("category").ToString()) : new JArray();
            JArray rawKeywords = content.GetValue("metaKeywords") != null ?(JArray)JsonConvert.DeserializeObject(content.GetValue("metaKeywords").ToString()) : new JArray();
            JArray rawCountry = content.GetValue("country") != null ? (JArray)JsonConvert.DeserializeObject(content.GetValue("country").ToString()) : new JArray();
            JArray rawJobSector = content.GetValue("jobSector") != null ? (JArray)JsonConvert.DeserializeObject(content.GetValue("jobSector").ToString()) : new JArray();
            JArray rawDuration = content.GetValue("duration") != null ? (JArray)JsonConvert.DeserializeObject(content.GetValue("duration").ToString()) : new JArray();
            JArray rawCommitment = content.GetValue("commitment") != null ? (JArray)JsonConvert.DeserializeObject(content.GetValue("commitment").ToString()) : new JArray();
            JArray rawCompensation = content.GetValue("compensation") != null ? (JArray)JsonConvert.DeserializeObject(content.GetValue("compensation").ToString()) : new JArray();
            JArray rawStatus = content.GetValue("status") != null ? (JArray)JsonConvert.DeserializeObject(content.GetValue("status").ToString()) : new JArray();

            string[] taggedCategories = rawCategories.ToObject<string[]>();
            string[] taggedKeywords = rawKeywords.ToObject<string[]>();
            string[] countries = rawCountry.ToObject<string[]>();
            string[] jobSectors = rawJobSector.ToObject<string[]>();
            string[] durations = rawDuration.ToObject<string[]>();
            string[] commitments = rawCommitment.ToObject<string[]>();
            string[] compensations = rawCompensation.ToObject<string[]>();
            string[] statuses = rawStatus.ToObject<string[]>();

            string keywords = utilities.ConcatenateStringArray(taggedKeywords);
            string country = countries.Length > 0 ? countries[0] : "";
            string jobSector = jobSectors.Length > 0 ? jobSectors[0] : "";
            string duration = durations.Length > 0 ? durations[0] : "";
            string commitment = commitments.Length > 0 ? commitments[0] : "";
            string compensation = compensations.Length > 0 ? compensations[0] : "";
            string status = statuses.Length > 0 ? statuses[0] : "";

            UmbracoApprenticeshipModel model = new UmbracoApprenticeshipModel()
            {
                ApprenticeshipId = content.Id,
                ApprenticeshipName = content.Name,
                Title = content.GetValue("title") != null ? content.GetValue("title").ToString() : "",
                PostDate = content.GetValue("postDate") != null ? (DateTime)content.GetValue("postDate") : DateTime.Now.Date,
                StartDate = content.GetValue("startDate") != null ? (DateTime)content.GetValue("startDate") : DateTime.Now.Date,
                EndDate = content.GetValue("endDate") != null ? (DateTime)content.GetValue("endDate") : DateTime.Now.Date,
                MetaName = content.GetValue("metaName") != null ? content.GetValue("metaName").ToString() : "",
                MetaDescription = content.GetValue("metaDescription") != null ? content.GetValue("metaDescription").ToString() : "",
                MetaKeywords = keywords,
                Duration = duration,
                Commitment = commitment,
                Compensation = compensation,
                Country = country,
                JobSector = jobSector,
                Status = status,
                SelectedCategories = taggedCategories,
                Categories = utilities.GetContentCategories(),
                Countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null),
                JobSectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null),
                Durations = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Duration", null),
                Commitments = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Commitment", null),
                Compensations = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Compensation", null),
                Statuses = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Status", null)

            };
            return model;
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitApprenticeshipDetail(UmbracoApprenticeshipModel model)
        {
            var contentService = Services.ContentService;
            var content = contentService.GetById(model.ApprenticeshipId);

            if (model != null && ModelState.IsValid)
            {
                UpdateApprenticeshipDetail(content, model);
                contentService.SaveAndPublish(content);
            }

            // required to set the sources again on post
            model.Countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
            model.JobSectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
            model.Durations = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Duration", null);
            model.Commitments = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Commitment", null);
            model.Compensations = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Compensation", null);
            model.Statuses = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Status", null);
            model.Categories = utilities.GetContentCategories();

            ViewData["successMessage"] = "Detail data were successfully saved at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);

            return PartialView(GetTasksViewPath("_ApprenticeshipDetail"), model);
        }

        public void UpdateApprenticeshipDetail(IContent content, UmbracoApprenticeshipModel model)
        {
            List<string> keywords = model.MetaKeywords.Split(',').ToList();
            List<string> categories = model.SelectedCategories.ToList();

            content.Name = model.ApprenticeshipName;
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Title).Alias, model.Title);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.PostDate).Alias, model.PostDate);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.StartDate).Alias, model.StartDate);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.EndDate).Alias, model.EndDate);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.MetaName).Alias, model.MetaName);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.MetaDescription).Alias, model.MetaDescription);          
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.JobSector).Alias, JsonConvert.SerializeObject(new[] { model.JobSector }));
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Duration).Alias, JsonConvert.SerializeObject(new[] { model.Duration }));
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Commitment).Alias, JsonConvert.SerializeObject(new[] { model.Commitment }));
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Compensation).Alias, JsonConvert.SerializeObject(new[] { model.Compensation }));
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Status).Alias, JsonConvert.SerializeObject(new[] { model.Status }));
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Category).Alias, JsonConvert.SerializeObject(categories));
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.MetaKeywords).Alias, JsonConvert.SerializeObject(keywords));
        }

        #endregion

        #region APPRENTICESHIP IMAGE FORM

        public ActionResult ApprenticeshipImage(int apprenticeshipId)
        {
            var contentService = Services.ContentService;
            var content = contentService.GetById(apprenticeshipId);
            ApprenticeshipImageModel model = new ApprenticeshipImageModel();

            string mediaUdi = content.GetValue("mainImage") != null ? content.GetValue("mainImage").ToString() : "";

            if (!string.IsNullOrEmpty(mediaUdi))
            {
                Udi imageUdi = Udi.Parse(mediaUdi);
                model.ImageUrl = Umbraco.PublishedContent(imageUdi).Url();
            }
            model.ApprenticeshipId = apprenticeshipId;

            return PartialView(GetTasksViewPath("_ApprenticeshipImage"), model);
        }

        public ActionResult SubmitApprenticeshipImage(ApprenticeshipImageModel model)
        {
            var contentService = Services.ContentService;
            var content = contentService.GetById(model.ApprenticeshipId);

            if (model.MainImage != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.MainImage.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_ApprenticeshipImage"), model);
                }
                var mediaUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.MainImage, PAGE_IMAGES_FOLDER_ID, "Image");
                content.SetValue(Apprenticeship.GetModelPropertyType(x => x.MainImage).Alias, mediaUdi);
                contentService.SaveAndPublish(content);

                string _mediaUdi = content.GetValue("mainImage") != null ? content.GetValue("mainImage").ToString() : "";
                if (!string.IsNullOrEmpty(_mediaUdi))
                {
                    Udi imageUdi = Udi.Parse(_mediaUdi);
                    model.ImageUrl = Umbraco.PublishedContent(imageUdi).Url();
                }
                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.MainImage.FileName);
            }
            return PartialView(GetTasksViewPath("_ApprenticeshipImage"), model);
        }

        #endregion

        #region APPRENTICESHIP RTE CONTENT FORM

        public ActionResult ApprenticeshipContent(int apprenticeshipId)
        {
            var contentService = Services.ContentService;
            var content = contentService.GetById(apprenticeshipId);

            UmbracoApprenticeshipModel model = new UmbracoApprenticeshipModel();

            model.Description = new HtmlString(content.GetValue("description").ToString());
            model.Responsibilities = new HtmlString(content.GetValue("responsibilities").ToString());
            model.Benefits = new HtmlString(content.GetValue("benefits").ToString());
            model.Qualifications = new HtmlString(content.GetValue("qualifications").ToString());

            model.ApprenticeshipId = apprenticeshipId;

            return PartialView(GetTasksViewPath("_ApprenticeshipContent"), model);
        }

        public ActionResult ApprenticeshipContentSave(string htmlText1, string htmlText2, string htmlText3, string htmlText4, int apprenticeshipId)
        {
            string msg = "The content of the apprenticeship was successfully saved.";

            var contentService = Services.ContentService;
            var content = contentService.GetById(apprenticeshipId);

            UmbracoApprenticeshipModel model = new UmbracoApprenticeshipModel();

            string htmlValue1 = JsonConvert.DeserializeObject(htmlText1).ToString();
            model.Description = new HtmlString(htmlValue1);

            string htmlValue2 = JsonConvert.DeserializeObject(htmlText2).ToString();
            model.Responsibilities = new HtmlString(htmlValue2);

            string htmlValue3 = JsonConvert.DeserializeObject(htmlText3).ToString();
            model.Benefits = new HtmlString(htmlValue3);

            string htmlValue4 = JsonConvert.DeserializeObject(htmlText4).ToString();
            model.Qualifications = new HtmlString(htmlValue4);

            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Description).Alias, model.Description);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Responsibilities).Alias, model.Responsibilities);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Benefits).Alias, model.Benefits);
            content.SetValue(Apprenticeship.GetModelPropertyType(x => x.Qualifications).Alias, model.Qualifications);

            contentService.SaveAndPublish(content);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #endregion MEMBER APPRENTICESHIPS

        public ActionResult AccessDenied()
        {
            return PartialView(GetTasksViewPath("_AccessDenied"));
        }

    }
}