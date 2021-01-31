using Appintern.Web.DAL;
using Appintern.Web.DAL.Services;
using Appintern.Web.Library;
using Appintern.Web.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public class BackendController : SurfaceController
    {
        private readonly AppinternWorksEntities db = new AppinternWorksEntities();
        private readonly Utilities utilities = new Utilities();
        private readonly ILogger _logger;

        private readonly StudentService studentService;
        private readonly GraduateService graduateService;
        private readonly SchoolService schoolService;
        private readonly EmployerService employerService;
        private readonly LiaisonOfficerService liaisonOfficerService;
        private readonly OrganizationService organizationService;
        private readonly AmbassadorService ambassadorService;
        private readonly TeacherService teacherService;
        private readonly ArticleService articleService;
        private readonly ApprenticeshipService apprenticeshipService;

        private readonly DataAccess dataAccess = new DataAccess();
        ServiceContext _serviceContext = Current.Services;

        private const string HOMEPAGE_DOCTYPE_ALIAS = "home";
        private const string APPR_LIST_DOCTYPE_ALIAS = "apprenticeshipList";
        private const string ARTICLELIST_DOCTYPE_ALIAS = "articleList";

        private const int HOME_PAGE_ID = 1080;
        private const int DASHBOARD_PAGE_ID = 1189;
        private const int APPRENTICESHIP_MAIN_PAGE_ID = 1427;
        private const int ARTICLELIST_MAIN_PAGE_ID = 1082;

        public BackendController(ILogger logger)
        {
            _logger = logger;

            studentService = new StudentService(new AppinternWorksEntities());
            graduateService = new GraduateService(new AppinternWorksEntities());
            schoolService = new SchoolService(new AppinternWorksEntities());
            employerService = new EmployerService(new AppinternWorksEntities());
            liaisonOfficerService = new LiaisonOfficerService(new AppinternWorksEntities());
            organizationService = new OrganizationService(new AppinternWorksEntities());
            ambassadorService = new AmbassadorService(new AppinternWorksEntities());
            teacherService = new TeacherService(new AppinternWorksEntities());
            articleService = new ArticleService(new AppinternWorksEntities());
            apprenticeshipService = new ApprenticeshipService(new AppinternWorksEntities());

            // Just testing to have this elsewhere in the project
            var member = Members.GetCurrentMember();

            var mail = member.GetProperty("Email").Value<string>();
        }

        protected override void Dispose(bool disposing)
        {
            studentService.Dispose();
            graduateService.Dispose();
            schoolService.Dispose();
            employerService.Dispose();
            liaisonOfficerService.Dispose();
            organizationService.Dispose();
            ambassadorService.Dispose();
            teacherService.Dispose();
            articleService.Dispose();
            apprenticeshipService.Dispose();

            base.Dispose(disposing);
        }

        private string GetBackendViewPath(string name)
        {
            return $"~/Views/Partials/Backend/{name}.cshtml";
        }

        private string GetPrintViewPath(string name)
        {
            return $"~/Views/Partials/PrintViews/{name}.cshtml";
        }

        #region DASHBOARD MAIN FUNCTIONS

        // This a telerik View outside Umbraco frame
        public ActionResult RenderDashboard()
        {
            return PartialView(GetBackendViewPath("_Dashboard"));
        }

        public ActionResult RenderDashboardHome()
        {
            return RedirectToUmbracoPage(DASHBOARD_PAGE_ID);
        }

        // Members list using Telerik Grid
        public ActionResult Members_Read([DataSourceRequest] DataSourceRequest request)
        {
            var result = utilities.GetAllMembers().OrderBy(p => p.Id);

            return Json(result.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateUrlSLugForAllMembers()
        {
            var members = utilities.GetAllMembers1().OrderBy(p => p.Name);

            foreach (var member in members)
            {
                string memberType = member.ContentType.Alias.ToString();
                int memberId = Current.Services.MemberService.GetById(member.Id).Id;

                string urlSLug = utilities.SetUrlSlugByMemberTypeAlias(memberId, memberType);

            }
            string message = "Batch update of the UrlSlug has completed successfully.";
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        #endregion


        #region MEMBER APPRENTICESHIPS GRIDS

        // View with two grids, Members and related Apprenticeships
        public ActionResult ApprenticeshipsMembers()
        {
            //return View();
            return PartialView(GetBackendViewPath("_ApprenticeshipsMembers"));
        }

        public ActionResult Employers_Read([DataSourceRequest] DataSourceRequest request)
        {

            var data = GetMembersOfGroup("Employers");

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ApprenticeshipsMembers_Read([DataSourceRequest] DataSourceRequest request, int employerId = 0)
        {
            var data = GetUmbracoApprenticeships(employerId);

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        // This works
        public List<EmployersViewModel> GetMembersOfGroup(string role)
        {
            var members = _serviceContext.MemberService.GetMembersByGroup(role);

            var data = (from d in members
                        orderby d.Name
                        select new EmployersViewModel
                        {
                            MemberID = d.Id,
                            TradeName = d.Name,
                            Email = d.Email,
                            LoginName = d.Username,
                        }).ToList();

            return data;
        }

        public List<ApprenticeshipViewModel> GetUmbracoApprenticeships(int employerId = 0)
        {
            List<ApprenticeshipViewModel> model = new List<ApprenticeshipViewModel>();

            // THESE ARE TESTED AND WORKING! //
            //IPublishedContent homePage1 = Umbraco.ContentAtRoot().Where(f => f.Name == "Home").FirstOrDefault();
            //IPublishedContent homePage = Umbraco.ContentAtRoot().Where(f => f.IsDocumentType(HOMEPAGE_DOCTYPE_ALIAS)).FirstOrDefault();
            //IPublishedContent apprenticeshipMain = homePage.Descendants().Where(x => x.IsDocumentType(APPR_LIST_DOCTYPE_ALIAS)).FirstOrDefault();
            //IEnumerable<IPublishedContent> apprenticeships1 = apprenticeshipMain.Children.OrderBy(x => x.Name);

            IPublishedContent apprenticeshipList = GetUmbracoNodeById(APPRENTICESHIP_MAIN_PAGE_ID);
            IEnumerable<IPublishedContent> apprenticeships = apprenticeshipList.Children.OrderBy(x => x.Name);

            foreach (IPublishedContent item in apprenticeships)
            {
                Employer employer = item.GetProperty("employer").GetValue() as Employer;
                if (employer.Id == employerId)
                {
                    int apprenticeshipId = item.Id;
                    string title = item.GetProperty("title").GetValue().ToString();
                    string duration = item.GetProperty("duration").GetValue().ToString();
                    string commitment = item.GetProperty("commitment").GetValue().ToString();
                    string compensation = item.GetProperty("compensation").GetValue().ToString();
                    string country = item.GetProperty("country").GetValue().ToString();
                    DateTime postDate = (DateTime)item.GetProperty("postDate").GetValue();

                    string[] jobSectors = item.GetProperty("industryCategories").GetValue() as string[];
                    string industryCategories = utilities.ConcatenateStringArray(jobSectors);

                    model.Add(new ApprenticeshipViewModel(apprenticeshipId, title, postDate, duration, commitment, compensation, industryCategories, country, employerId));
                }
            }
            return model;
        }

        #endregion


        #region MEMBER ARTICLES GRIDS

        public ActionResult ArticlesMembers()
        {
            //return View();
            return PartialView(GetBackendViewPath("_ArticlesMembers"));
        }

        public ActionResult AllMembers_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = utilities.GetAllMembers().OrderBy(x => x.Type).ThenBy(x => x.Name);

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Articles_Read([DataSourceRequest] DataSourceRequest request, int memberId = 0, string memberType = null)
        {
            var data = GetArticles(memberId, memberType);

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<ArticleViewModel> GetArticles(int memberId = 0, string memberType = null)
        {
            List<ArticleViewModel> model = new List<ArticleViewModel>();

            // Not the elegant way //
            //IPublishedContent articlesList = GetUmbracoNodeById(ARTICLELIST_MAIN_PAGE_ID);
            //IEnumerable<IPublishedContent> articles = articlesList.Children.OrderBy(x => x.Name);

            IPublishedContent homePage = Umbraco.ContentAtRoot().Where(f => f.IsDocumentType(HOMEPAGE_DOCTYPE_ALIAS)).FirstOrDefault();
            IPublishedContent articlesList = homePage.Descendants().Where(x => x.IsDocumentType(ARTICLELIST_DOCTYPE_ALIAS)).FirstOrDefault();

            foreach (IPublishedContent item in articlesList.Children.OrderBy(x => x.Name))
            {
                // switch case here for member type
                int resultId = MemberTypeId(item, memberType);

                if (resultId == memberId)
                {
                    int articleId = item.Id;
                    DateTime articleDate = (DateTime)item.GetProperty("articleDate").GetValue();
                    string authorName = item.GetProperty("authorName").GetValue().ToString();
                    string title = item.GetProperty("title").GetValue().ToString();
                    string description = item.GetProperty("description").GetValue().ToString();
                    string country = item.GetProperty("country").GetValue().ToString();

                    model.Add(new ArticleViewModel(articleId, articleDate, authorName, title, description, country, memberId));
                }
            }
            return model;
        }

        public int MemberTypeId(IPublishedContent item, string memberType)
        {
            if (memberType == "ambassador")
            {
                Ambassador articleMember = item.GetProperty("articleMember").GetValue() as Ambassador;
                if (articleMember != null)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "employer")
            {
                Employer articleMember = item.GetProperty("articleMember").GetValue() as Employer;
                if (articleMember != null)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "graduate")
            {
                Graduate articleMember = item.GetProperty("articleMember").GetValue() as Graduate;
                if (articleMember != null)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "liaison")
            {
                Liaison articleMember = item.GetProperty("articleMember").GetValue() as Liaison;
                if (articleMember != null)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "organization")
            {
                Organization articleMember = item.GetProperty("articleMember").GetValue() as Organization;
                if (articleMember != null)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "school")
            {
                School articleMember = item.GetProperty("articleMember").GetValue() as School;
                if (articleMember != null)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "student")
            {
                Student articleMember = item.GetProperty("articleMember").GetValue() as Student;
                if (articleMember != null)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "teacher")
            {
                Teacher articleMember = item.GetProperty("articleMember").GetValue() as Teacher;
                if (articleMember != null)
                    return articleMember.Id;
                else
                    return 0;
            }
            else if (memberType == "Member")
            {
                CM.Member articleMember = item.GetProperty("articleMember").GetValue() as CM.Member;
                if (articleMember != null)
                    return articleMember.Id;
                else
                    return 0;
            }
            else
                return 0;
        }

        #endregion


        #region UMBRACO NODE GETTER BY ID

        /// <summary>
        /// Gets a node by its Id. Does not work if the node is empty
        /// </summary>
        /// <param name="nodeid"></param>
        /// <returns></returns>
        public IPublishedContent GetUmbracoNodeById(int nodeid)
        {
            var helper = Current.UmbracoHelper;
            IPublishedContent node = helper.Content(nodeid);
            return node;
        }

        #endregion


        #region ARTICLES GRID

        public ActionResult ArticlesMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_ArticlesMain"));
        }

        public ActionResult ArticlesMain_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetArticlesFromDatabase();
            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public ActionResult PopulateArticles()
        {
            string message = "Population of articles database completed successfully.";
            List<ArticleViewModel> data = new List<ArticleViewModel>();

            List<string> memberTypes = utilities.MemberTypesList();

            IPublishedContent homePage = Umbraco.ContentAtRoot().Where(f => f.IsDocumentType(HOMEPAGE_DOCTYPE_ALIAS)).FirstOrDefault();
            IPublishedContent articlesList = homePage.Descendants().Where(x => x.IsDocumentType(ARTICLELIST_DOCTYPE_ALIAS)).FirstOrDefault();

            foreach (IPublishedContent item in articlesList.Children.OrderBy(x => x.Name))
            {
                int articleId = item.Id;
                DateTime articleDate = (DateTime)item.GetProperty("articleDate").GetValue();
                string authorName = item.GetProperty("authorName").GetValue().ToString();
                string title = item.GetProperty("title").GetValue().ToString();
                string description = item.GetProperty("description").GetValue().ToString();
                string country = item.GetProperty("country").GetValue().ToString();

                int memberId = GetMemberId(item, memberTypes);

                data.Add(new ArticleViewModel(articleId, articleDate, authorName, title, description, country, memberId));
            }

            foreach (ArticleViewModel article in data)
            {
                CreateOrUpdateArticle(article);
            }

            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateArticle(ArticleViewModel model)
        {
            var data = (from d in db.Articles where d.ArticleId == model.ArticleId select d).FirstOrDefault();
            if (data != null)
                articleService.Update(model);
            else
                articleService.Create(model);
        }

        public List<ArticleViewModel> GetArticlesFromDatabase()
        {
            var data = (from d in db.Articles
                        orderby d.ArticleDate descending, d.Title
                        select new ArticleViewModel
                        {
                            ArticleId = d.ArticleId,
                            ArticleDate = d.ArticleDate,
                            AuthorName = d.AuthorName,
                            Title = d.Title,
                            Description = d.Description,
                            Country = d.Country,
                            ArticleMemberId = d.ArticleMemberID ?? 0
                        }).ToList();
            return data;
        }
        
        /// <summary>
        /// Computes member Id of item (article) depending on the member type found 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="memberTypes"></param>
        /// <returns>int with the member Id</returns>
        public int GetMemberId(IPublishedContent item, List<string> memberTypes)
        {
            int memberId = 0;
            bool found = false;

            foreach(var memberType in memberTypes)
            {
                if (memberType == "ambassador" && !found)
                {
                    Ambassador articleMember = item.GetProperty("articleMember").GetValue() as Ambassador;
                    if (articleMember != null)
                    {
                        memberId = articleMember.Id;
                        found = true;
                    }
                }
                else if (memberType == "employer" && !found)
                {
                    Employer articleMember = item.GetProperty("articleMember").GetValue() as Employer;
                    if (articleMember != null)
                    {
                        memberId = articleMember.Id;
                        found = true;
                    }
                }
                else if (memberType == "graduate" && !found)
                {
                    Graduate articleMember = item.GetProperty("articleMember").GetValue() as Graduate;
                    if (articleMember != null)
                    {
                        memberId = articleMember.Id;
                        found = true;
                    }
                }
                else if (memberType == "liaison" && !found)
                {
                    Liaison articleMember = item.GetProperty("articleMember").GetValue() as Liaison;
                    if (articleMember != null)
                    {
                        memberId = articleMember.Id;
                        found = true;
                    }
                }
                else if (memberType == "organization" && !found)
                {
                    Organization articleMember = item.GetProperty("articleMember").GetValue() as Organization;
                    if (articleMember != null)
                    {
                        memberId = articleMember.Id;
                        found = true;
                    }
                }
                else if (memberType == "school" && !found)
                {
                    School articleMember = item.GetProperty("articleMember").GetValue() as School;
                    if (articleMember != null)
                    {
                        memberId = articleMember.Id;
                        found = true;
                    }
                }
                else if (memberType == "student" && !found)
                {
                    Student articleMember = item.GetProperty("articleMember").GetValue() as Student;
                    if (articleMember != null)
                    {
                        memberId = articleMember.Id;
                        found = true;
                    }
                }
                else if (memberType == "teacher" && !found)
                {
                    Teacher articleMember = item.GetProperty("articleMember").GetValue() as Teacher;
                    if (articleMember != null)
                    {
                        memberId = articleMember.Id;
                        found = true;
                    }
                }
                else if (memberType == "Member" && !found)
                {
                    CM.Member articleMember = item.GetProperty("articleMember").GetValue() as CM.Member;
                    if (articleMember != null)
                    {
                        memberId = articleMember.Id;
                        found = true;
                    }
                }
            }
            return memberId;
        }

        #endregion


        #region APPRENTICESHIPS GRID

        public ActionResult ApprenticeshipsMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_ApprenticeshipsMain"));
        }

        public ActionResult Apprenticeships_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetApprenticeshipsFromDatabase();
            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<ApprenticeshipViewModel> GetApprenticeshipsFromDatabase()
        {
            var data = (from d in db.Apprenticeships
                        orderby d.PostDate descending, d.Title
                        select new ApprenticeshipViewModel
                        {
                            ApprenticeshipID = d.ApprenticeshipID,
                            PostDate = d.PostDate,
                            DurationMonths = d.DurationMonths,
                            Title = d.Title,
                            Description = d.Description,
                            Commitment = d.Commitment,
                            Compensation = d.Compensation,
                            Requirements = d.Requirements,
                            Country = d.Country,
                            JobSector = d.JobSector,
                            EmployerID = d.EmployerID ?? 0
                        }).ToList();
            return data;
        }

        public ActionResult PopulateApprenticeships()
        {
            string message = "Population of apprenticeships database completed successfully.";
            List<ApprenticeshipViewModel> data = new List<ApprenticeshipViewModel>();

            IPublishedContent homePage = Umbraco.ContentAtRoot().Where(f => f.IsDocumentType(HOMEPAGE_DOCTYPE_ALIAS)).FirstOrDefault();
            IPublishedContent apprenticeshipList = homePage.Descendants().Where(x => x.IsDocumentType(APPR_LIST_DOCTYPE_ALIAS)).FirstOrDefault();

            foreach (IPublishedContent item in apprenticeshipList.Children.OrderBy(x => x.Name))
            {
                int apprenticeshipId = item.Id;
                string title = item.GetProperty("title").GetValue().ToString();
                string duration = item.GetProperty("duration").GetValue().ToString();
                string commitment = item.GetProperty("commitment").GetValue().ToString();
                string compensation = item.GetProperty("compensation").GetValue().ToString();
                string country = item.GetProperty("country").GetValue().ToString();
                DateTime postDate = (DateTime)item.GetProperty("postDate").GetValue();
                Employer employer = item.GetProperty("employer").GetValue() as Employer;

                string[] jobSectors = item.GetProperty("industryCategories").GetValue() as string[];
                string industryCategories = utilities.ConcatenateStringArray(jobSectors);

                string description = HtmlUtilities.ConvertToPlainText(item.GetProperty("description").GetValue().ToString());

                data.Add(new ApprenticeshipViewModel(apprenticeshipId, title, postDate, duration, commitment, compensation, industryCategories, country, employer.Id, description));
            }
            foreach (ApprenticeshipViewModel model in data)
            {
                CreateOrUpdateApprenticeship(model);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateApprenticeship(ApprenticeshipViewModel model)
        {
            var data = (from d in db.Apprenticeships where d.ApprenticeshipID == model.ApprenticeshipID select d).FirstOrDefault();
            if (data != null)
                apprenticeshipService.Update(model);
            else
                apprenticeshipService.Create(model);
        }

        #endregion


        #region 1. BUSINESS AMBASSADORS GRID

        public ActionResult AmbassadorsMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_AmbassadorsMain"));
        }

        public ActionResult AmbassadorsMain_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetAmbassadorsFromDatabase();

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<AmbassadorsViewModel> GetAmbassadorsFromDatabase()
        {
            var data = (from d in db.Ambassadors
                        orderby d.FullName
                        select new AmbassadorsViewModel
                        {
                            MemberID = d.MemberID,
                            LoginName = d.LoginName,
                            Email = d.Email,
                            FullName = d.FullName,
                            Gender = d.Gender,
                            Address = d.Address,
                            City = d.City,
                            State = d.State,
                            Country = d.Country,
                            Phone = d.Phone,
                            Fax = d.Fax,
                            Zip = d.Zip,
                            JobSector = d.JobSector,
                            WorkingYears = d.WorkingYears,
                            Employer = d.Employer
                        }).ToList();
            return data;
        }

        public ActionResult PopulateAmbassadors()
        {
            string message = "Population of ambassadors database completed successfully.";

            IEnumerable<IMember> typeMembers = _serviceContext.MemberService.GetMembersByMemberType("ambassador");

            foreach (var user in typeMembers)
            {
                AmbassadorsViewModel model = new AmbassadorsViewModel();

                Ambassador entity = Members.GetById(user.Id) as Ambassador;

                model.MemberID = user.Id;
                model.LoginName = user.Username;
                model.Email = user.Email;
                model.FullName = entity.FullName;
                model.Gender = entity.Gender;
                model.Address = entity.Address;
                model.City = entity.City;
                model.State = entity.State;
                model.Country = entity.Country;
                model.Phone = entity.Phone;
                model.Fax = entity.Fax;
                model.Zip = entity.Zip;
                model.JobSector = entity.JobSector;
                model.WorkingYears = entity.WorkingYears;
                model.Employer = entity.Employer;

                CreateOrUpdateAmbassador(model);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateAmbassador(AmbassadorsViewModel model)
        {
            var data = (from d in db.Ambassadors where d.MemberID == model.MemberID select d).FirstOrDefault();
            if (data != null)
                ambassadorService.Update(model);
            else
                ambassadorService.Create(model);
        }

        #endregion


        #region 2. EMPLOYERS GRID

        public ActionResult EmployersMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_EmployersMain"));
        }

        public ActionResult EmployersMain_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetEmployersFromDatabase();

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<EmployersViewModel> GetEmployersFromDatabase()
        {
            var data = (from d in db.Employers
                        orderby d.TradeName
                        select new EmployersViewModel
                        {
                            MemberID = d.MemberID,
                            LoginName = d.LoginName,
                            Email = d.Email,
                            TradeName = d.TradeName,
                            Address = d.Address,
                            City  = d.City,
                            State = d.State,
                            Country = d.Country,
                            Phone = d.Phone,
                            Fax = d.Fax,
                            Zip = d.Zip,
                            JobSector = d.JobSector,
                            ContactPerson = d.ContactPerson
                        }).ToList();
            return data;
        }

        public ActionResult PopulateEmployers()
        {
            string message = "Population of employers database completed successfully.";

            IEnumerable<IMember> typeMembers = _serviceContext.MemberService.GetMembersByMemberType("employer");

            foreach(var user in typeMembers)
            {
                EmployersViewModel model = new EmployersViewModel();

                Employer entity = Members.GetById(user.Id) as Employer;

                model.MemberID = user.Id;
                model.LoginName = user.Username;
                model.Email = user.Email;
                model.TradeName = entity.CompanyName;
                model.Address = entity.Address;
                model.City = entity.City;
                model.State = entity.State;
                model.Country = entity.Country;
                model.Phone = entity.Phone;
                model.Fax = entity.Fax;
                model.Zip = entity.Zip;
                model.JobSector = entity.JobSector;
                model.ContactPerson = entity.ContactPerson;

                CreateOrUpdateEmployer(model);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateEmployer(EmployersViewModel model)
        {
            var data = (from d in db.Employers where d.MemberID == model.MemberID select d).FirstOrDefault();
            if (data != null)
                employerService.Update(model);
            else
                employerService.Create(model);
        }

        #endregion


        #region 3. GRADUATES GRID

        public ActionResult GraduatesMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_GraduatesMain"));
        }

        public ActionResult GraduatesMain_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetGraduatesFromDatabase();

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<GraduatesViewModel> GetGraduatesFromDatabase()
        {
            var data = (from d in db.Graduates
                        orderby d.FullName
                        select new GraduatesViewModel
                        {
                            MemberID = d.MemberID,
                            LoginName = d.LoginName,
                            Email = d.Email,
                            FullName = d.FullName,
                            Gender = d.Gender,
                            Birthdate = d.Birthdate,
                            Address = d.Address,
                            City = d.City,
                            State = d.State,
                            Country = d.Country,
                            Phone = d.Phone,
                            Zip = d.Zip,
                            JobSector = d.JobSector,
                            Specialty = d.Specialty,
                            School = d.School
                        }).ToList();
            return data;
        }

        public ActionResult PopulateGraduates()
        {
            string message = "Population of graduates database completed successfully.";

            IEnumerable<IMember> typeMembers = _serviceContext.MemberService.GetMembersByMemberType("graduate");

            foreach (var user in typeMembers)
            {
                GraduatesViewModel model = new GraduatesViewModel();

                Graduate entity = Members.GetById(user.Id) as Graduate;

                model.MemberID = user.Id;
                model.LoginName = user.Username;
                model.Email = user.Email;
                model.FullName = entity.FullName;
                model.Gender = entity.Gender;
                model.Birthdate = entity.BirthDate;
                model.Address = entity.Address;
                model.City = entity.City;
                model.State = entity.State;
                model.Country = entity.Country;
                model.Phone = entity.Phone;
                model.Zip = entity.Zip;
                model.JobSector = entity.JobSector;
                model.Specialty = entity.Specialty;
                model.School = entity.School;

                CreateOrUpdateGraduate(model);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateGraduate(GraduatesViewModel model)
        {
            var data = (from d in db.Graduates where d.MemberID == model.MemberID select d).FirstOrDefault();
            if (data != null)
                graduateService.Update(model);
            else
                graduateService.Create(model);
        }

        #endregion


        #region 4. LIAISON OFFICERS GRID

        public ActionResult LiaisonsMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_LiaisonsMain"));
        }

        public ActionResult LiaisonsMain_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetLiaisonsFromDatabase();

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<LiaisonOfficersViewModel> GetLiaisonsFromDatabase()
        {
            var data = (from d in db.LiaisonOfficers
                        orderby d.FullName
                        select new LiaisonOfficersViewModel
                        {
                            MemberID = d.MemberID,
                            LoginName = d.LoginName,
                            Email = d.Email,
                            FullName = d.FullName,
                            Gender = d.Gender,
                            Address = d.Address,
                            City = d.City,
                            State = d.State,
                            Country = d.Country,
                            Phone = d.Phone,
                            Fax = d.Fax,
                            Zip = d.Zip,
                            JobSector = d.JobSector,
                            Employer = d.Employer,
                            WorkingYears = d.WorkingYears
                        }).ToList();
            return data;
        }

        public ActionResult PopulateLiaisons()
        {
            string message = "Population of liaison officers database completed successfully.";

            IEnumerable<IMember> typeMembers = _serviceContext.MemberService.GetMembersByMemberType("liaison");

            foreach (var user in typeMembers)
            {
                LiaisonOfficersViewModel model = new LiaisonOfficersViewModel();

                Liaison entity = Members.GetById(user.Id) as Liaison;

                model.MemberID = user.Id;
                model.LoginName = user.Username;
                model.Email = user.Email;
                model.FullName = entity.FullName;
                model.Gender = entity.Gender;
                model.Address = entity.Address;
                model.City = entity.City;
                model.State = entity.State;
                model.Country = entity.Country;
                model.Phone = entity.Phone;
                model.Fax = entity.Fax;
                model.Zip = entity.Zip;
                model.JobSector = entity.JobSector;
                model.Employer = entity.Employer;
                model.WorkingYears = entity.WorkingYears;

                CreateOrUpdateLiaison(model);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateLiaison(LiaisonOfficersViewModel model)
        {
            var data = (from d in db.LiaisonOfficers where d.MemberID == model.MemberID select d).FirstOrDefault();
            if (data != null)
                liaisonOfficerService.Update(model);
            else
                liaisonOfficerService.Create(model);
        }

        #endregion


        #region 5. ORGANIZATIONS GRID

        public ActionResult OrganizationsMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_OrganizationsMain"));
        }

        public ActionResult OrganizationsMain_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetOrganizationsFromDatabase();

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<OrganizationsViewModel> GetOrganizationsFromDatabase()
        {
            var data = (from d in db.Organizations
                        orderby d.OrganizationName
                        select new OrganizationsViewModel
                        {
                            MemberID = d.MemberID,
                            LoginName = d.LoginName,
                            Email = d.Email,
                            OrganizationName = d.OrganizationName,
                            Address = d.Address,
                            City = d.City,
                            State = d.State,
                            Country = d.Country,
                            Phone = d.Phone,
                            Fax = d.Fax,
                            Zip = d.Zip,
                            JobSector = d.JobSector,
                            ContactPerson = d.ContactPerson
                        }).ToList();
            return data;
        }

        public ActionResult PopulateOrganizations()
        {
            string message = "Population of organizations database completed successfully.";

            IEnumerable<IMember> typeMembers = _serviceContext.MemberService.GetMembersByMemberType("organization");

            foreach (var user in typeMembers)
            {
                OrganizationsViewModel model = new OrganizationsViewModel();

                Organization entity = Members.GetById(user.Id) as Organization;

                model.MemberID = user.Id;
                model.LoginName = user.Username;
                model.Email = user.Email;
                model.OrganizationName = entity.OrganizationName;
                model.Address = entity.Address;
                model.City = entity.City;
                model.State = entity.State;
                model.Country = entity.Country;
                model.Phone = entity.Phone;
                model.Fax = entity.Fax;
                model.Zip = entity.Zip;
                model.JobSector = entity.JobSector;
                model.ContactPerson = entity.ContactPerson;

                CreateOrUpdateOrganization(model);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateOrganization(OrganizationsViewModel model)
        {
            var data = (from d in db.Organizations where d.MemberID == model.MemberID select d).FirstOrDefault();
            if (data != null)
                organizationService.Update(model);
            else
                organizationService.Create(model);
        }

        #endregion


        #region 6. SCHOOLS GRID

        public ActionResult SchoolsMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_SchoolsMain"));
        }

        public ActionResult SchoolsMain_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetSchoolsFromDatabase();

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<SchoolsViewModel> GetSchoolsFromDatabase()
        {
            var data = (from d in db.Schools
                        orderby d.SchoolName
                        select new SchoolsViewModel
                        {
                            MemberID = d.MemberID,
                            LoginName = d.LoginName,
                            Email = d.Email,
                            SchoolName = d.SchoolName,
                            Address = d.Address,
                            City = d.City,
                            State = d.State,
                            Country = d.Country,
                            Phone = d.Phone,
                            Fax = d.Fax,
                            Zip = d.Zip,
                            ContactPerson = d.ContactPerson
                        }).ToList();
            return data;
        }

        public ActionResult PopulateSchools()
        {
            string message = "Population of schools database completed successfully.";

            IEnumerable<IMember> typeMembers = _serviceContext.MemberService.GetMembersByMemberType("school");

            foreach (var user in typeMembers)
            {
                SchoolsViewModel model = new SchoolsViewModel();

                School entity = Members.GetById(user.Id) as School;

                model.MemberID = user.Id;
                model.LoginName = user.Username;
                model.Email = user.Email;
                model.SchoolName = entity.SchoolName;
                model.ContactPerson = entity.ContactPerson;
                model.Address = entity.Address;
                model.City = entity.City;
                model.State = entity.State;
                model.Zip = entity.Zip;
                model.Country = entity.Country;
                model.Phone = entity.Phone;
                model.Fax = entity.Fax;

                CreateOrUpdateSchool(model);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateSchool(SchoolsViewModel model)
        {
            var data = (from d in db.Schools where d.MemberID == model.MemberID select d).FirstOrDefault();
            if (data != null)
                schoolService.Update(model);
            else
                schoolService.Create(model);
        }

        #endregion


        #region 7. STUDENTS GRID

        public ActionResult StudentsMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_StudentsMain"));
        }

        public ActionResult StudentsMain_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetStudentsFromDatabase();

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<StudentsViewModel> GetStudentsFromDatabase()
        {
            var data = (from d in db.Students
                        orderby d.FullName
                        select new StudentsViewModel
                        {
                            MemberID = d.MemberID,
                            LoginName = d.LoginName,
                            Email = d.Email,
                            FullName = d.FullName,
                            Gender = d.Gender,
                            Birthdate = d.Birthdate,
                            Address = d.Address,
                            City = d.City,
                            State = d.State,
                            Country = d.Country,
                            Phone = d.Phone,
                            Zip = d.Zip,
                            JobSector = d.JobSector,
                            Specialty = d.Specialty,
                            School = d.School
                        }).ToList();
            return data;
        }

        public ActionResult PopulateStudents()
        {
            string message = "Population of students database completed successfully.";

            IEnumerable<IMember> typeMembers = _serviceContext.MemberService.GetMembersByMemberType("student");

            foreach (var user in typeMembers)
            {
                StudentsViewModel model = new StudentsViewModel();

                Student entity = Members.GetById(user.Id) as Student;

                model.MemberID = user.Id;
                model.LoginName = user.Username;
                model.Email = user.Email;
                model.FullName = entity.FullName;
                model.Gender = entity.Gender;
                model.Birthdate = entity.BirthDate;
                model.Address = entity.Address;
                model.City = entity.City;
                model.State = entity.State;
                model.Country = entity.Country;
                model.Phone = entity.Phone;
                model.Zip = entity.Zip;
                model.JobSector = entity.JobSector;
                model.Specialty = entity.Specialty;
                model.School = entity.School;

                CreateOrUpdateStudent(model);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateStudent(StudentsViewModel model)
        {
            var data = (from d in db.Students where d.MemberID == model.MemberID select d).FirstOrDefault();
            if (data != null)
                studentService.Update(model);
            else
                studentService.Create(model);
        }

        #endregion


        #region 8. TRAINERS-TEACHERS GRID

        public ActionResult TeachersMain()
        {
            //return View();
            return PartialView(GetBackendViewPath("_TeachersMain"));
        }

        public ActionResult TeachersMain_Read([DataSourceRequest] DataSourceRequest request)
        {
            var data = GetTeachersFromDatabase();

            return Json(data.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public List<TeachersViewModel> GetTeachersFromDatabase()
        {
            var data = (from d in db.Teachers
                        orderby d.FullName
                        select new TeachersViewModel
                        {
                            MemberID = d.MemberID,
                            LoginName = d.LoginName,
                            Email = d.Email,
                            FullName = d.FullName,
                            Gender = d.Gender,
                            Address = d.Address,
                            City = d.City,
                            State = d.State,
                            Country = d.Country,
                            Phone = d.Phone,
                            Fax = d.Fax,
                            Zip = d.Zip,
                            JobSector = d.JobSector,
                            School = d.School,
                            TeachingYears = d.TeachingYears
                        }).ToList();
            return data;
        }

        public ActionResult PopulateTeachers()
        {
            string message = "Population of teachers database completed successfully.";

            IEnumerable<IMember> typeMembers = _serviceContext.MemberService.GetMembersByMemberType("teacher");

            foreach (var user in typeMembers)
            {
                TeachersViewModel model = new TeachersViewModel();

                Teacher entity = Members.GetById(user.Id) as Teacher;

                model.MemberID = user.Id;
                model.LoginName = user.Username;
                model.Email = user.Email;
                model.FullName = entity.FullName;
                model.Gender = entity.Gender;
                model.Address = entity.Address;
                model.City = entity.City;
                model.State = entity.State;
                model.Country = entity.Country;
                model.Phone = entity.Phone;
                model.Zip = entity.Zip;
                model.JobSector = entity.JobSector;
                model.School = entity.School;
                model.TeachingYears = entity.TeachingYears;

                CreateOrUpdateTeacher(model);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public void CreateOrUpdateTeacher(TeachersViewModel model)
        {
            var data = (from d in db.Teachers where d.MemberID == model.MemberID select d).FirstOrDefault();
            if (data != null)
                teacherService.Update(model);
            else
                teacherService.Create(model);
        }

        #endregion


        #region APPINTERNWORKS GETTERS

        public void MemberGroupsList()
        {
            var data = (from d in db.MemberGroups
                        orderby d.MemberGroupText
                        select new MemberGroupViewModel
                        {
                            MemberGroupID = d.MemberGroupID,
                            MemberGroupText = d.MemberGroupText
                        }).ToList();

            ViewBag.MemberGroups = new SelectList(data, "MemberGroupID", "MemberGroupText");

            return;
        }

        public JsonResult GetGenders()
        {
            var genders = db.Genders.Select(p => new GenderViewModel
            {
                GenderID = p.GenderID,
                GenderText = p.GenderText
            });

            return Json(genders, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMemberGroups()
        {
            var data = (from d in db.MemberGroups
                        orderby d.MemberGroupText
                        select new MemberGroupViewModel
                        {
                            MemberGroupID = d.MemberGroupID,
                            MemberGroupText = d.MemberGroupText
                        }).ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }


        #endregion

        public ActionResult MembersArticlesPrint()
        {
            //return View();
            return PartialView(GetPrintViewPath("_PrintMemberArticles"));
        }

        public ActionResult MembersApprenticeshipsPrint()
        {
            //return View();
            return PartialView(GetPrintViewPath("_PrintMemberApprenticeships"));
        }

        public ActionResult MembersArticlesReport()
        {
            //return View();
            return PartialView(GetPrintViewPath("_ReportViewerView"));
        }

        public ActionResult MembersArticlesTestPrint()
        {
            //return View();
            return PartialView(GetPrintViewPath("_MembersArticlesPrint"));
        }

    }
}