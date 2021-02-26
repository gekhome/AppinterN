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
using Umbraco.Web.Security;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;
using CM = Umbraco.Web.PublishedModels;

namespace Appintern.Web.Controllers
{
    public class TasksProfileController     :   SurfaceController
    {
        private readonly Utilities utilities = new Utilities();
        private readonly ILogger _logger;
        private LoggedMemberModel loggedMember;
        private readonly IDataTypeValueService _dataTypeValueService;
        private readonly IMediaUploadService _mediaUploadService;

        private const int HOME_PAGE_ID = 1080;
        private const int TASKS_MAIN_PAGE_ID = 1539;    // Member Dashboard page
        private const int MEDIA_DOC_FOLDER_ID = 1390;
        private const int MEDIA_AVATAR_FOLDER_ID = 1462;

        public TasksProfileController(ILogger logger, IDataTypeValueService dataTypeValueService, IMediaUploadService mediaUploadService)
        {
            _logger = logger;
            _dataTypeValueService = dataTypeValueService;
            _mediaUploadService = mediaUploadService;

            loggedMember = GetLoggedMember();
        }

        #region TasksMember Utility Functions 

        private string GetTasksViewPath(string name)
        {
            return $"~/Views/Partials/TasksProfile/{name}.cshtml";
        }

        public ActionResult RenderTasksHome()
        {
            return PartialView(GetTasksViewPath("_TasksHome"));
        }

        public ActionResult RenderTasksMain()
        {
            return RedirectToUmbracoPage(TASKS_MAIN_PAGE_ID);
        }

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

        public ActionResult RenderProfileMain()
        {
            string memberType = loggedMember.MemberType;
            int memberId = loggedMember.MemberId;

            if (loggedMember.MemberType == "ambassador")
            {
                return RedirectToAction("AmbassadorDetail", "TasksProfile");
            }
            else if (loggedMember.MemberType == "employer")
            {
                return RedirectToAction("EmployerDetail", "TasksProfile");
            }
            else if (loggedMember.MemberType == "graduate")
            {
                return RedirectToAction("GraduateDetail", "TasksProfile");
            }
            else if (loggedMember.MemberType == "liaison")
            {
                return RedirectToAction("LiaisonDetail", "TasksProfile");
            }
            else if (loggedMember.MemberType == "organization")
            {
                return RedirectToAction("OrganizationDetail", "TasksProfile");
            }
            else if (loggedMember.MemberType == "school")
            {
                return RedirectToAction("SchoolDetail", "TasksProfile");
            }
            else if (loggedMember.MemberType == "student")
            {
                return RedirectToAction("StudentDetail", "TasksProfile");
            }
            else if (loggedMember.MemberType == "teacher")
            {
                return RedirectToAction("TeacherDetail", "TasksProfile");
            }
            else
            {
                return RedirectToAction("MemberDetail", "TasksProfile");
            }
        }

        #region BUSINESS AMBASSADOR PROFILE

        public ActionResult AmbassadorDetail()
        {
            Ambassador memberProfile = Members.GetById(loggedMember.MemberId) as Ambassador;
            AmbassadorProfileModel model = GetAmbassadorModel(memberProfile);

            return PartialView(GetTasksViewPath("_AmbassadorDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitAmbassadorDetail(AmbassadorProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.FullName).Alias, model.FullName);
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.Address).Alias, model.Address);
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.Website).Alias, model.Website);
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.SocialMedia).Alias, model.SocialMedia);
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.Occupation).Alias, model.Occupation);
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.JobSector).Alias, JsonConvert.SerializeObject(new[] { model.JobSector }));
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.Employer).Alias, model.Employer);

                Current.Services.MemberService.Save(member);

                IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
                model.CountryList = countries;
                model.JobSectorList = jobsectors;

                ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
            return PartialView(GetTasksViewPath("_AmbassadorDetail"), model);
        }

        public ActionResult AmbassadorImage(int memberId)
        {
            Ambassador memberProfile = Members.GetById(memberId) as Ambassador;
            MemberImageModel model = new MemberImageModel();

            string mediaUrl = memberProfile.Avatar != null ? memberProfile.Avatar.Url() : "" ;

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.ImageUrl = mediaUrl;
            }
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_AmbassadorImage"), model);
        }

        public ActionResult SubmitAmbassadorImage(MemberImageModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Avatar != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Avatar.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_AmbassadorImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Avatar, MEDIA_AVATAR_FOLDER_ID, "Image");

                member.SetValue(Ambassador.GetModelPropertyType(p => p.Avatar).Alias, imageUdi);
                Current.Services.MemberService.Save(member);

                Ambassador memberProfile = Members.GetById(model.MemberId) as Ambassador;
                model.ImageUrl = memberProfile.Avatar.Url();

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Avatar.FileName);
            }
            return PartialView(GetTasksViewPath("_AmbassadorImage"), model);
        }

        public ActionResult AmbassadorSummary(int memberId)
        {
            Ambassador memberProfile = Members.GetById(memberId) as Ambassador;
            AmbassadorProfileModel model = new AmbassadorProfileModel();

            model.BioSummary = new HtmlString(memberProfile.BioSummary.ToString());
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_AmbassadorSummary"), model);
        }

        public ActionResult AmbassadorSummarySave(string htmlText, int memberId)
        {
            string msg = "The content of the bio summary was successfully saved.";

            AmbassadorProfileModel model = new AmbassadorProfileModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            // Do this to get rid of the enclosing quotation marks ""
            model.BioSummary = new HtmlString(htmlValue);

            var member = Current.Services.MemberService.GetById(memberId);

            member.SetValue(Ambassador.GetModelPropertyType(p => p.BioSummary).Alias, model.BioSummary);
            Current.Services.MemberService.Save(member);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AmbassadorDocument(int memberId)
        {
            Ambassador memberProfile = Members.GetById(memberId) as Ambassador;
            MemberDocumentModel model = new MemberDocumentModel();

            string mediaUrl = memberProfile.BioAttachment != null ? memberProfile.BioAttachment.Url() : "" ;

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.FileUrl = mediaUrl;
            }
            model.MemberId = memberId;
            model.FileName = memberProfile.BioAttachment != null ? memberProfile.BioAttachment.Name : "";

            return PartialView(GetTasksViewPath("_AmbassadorDocument"), model);
        }

        public ActionResult SubmitAmbassadorFile(MemberDocumentModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Attachment != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Attachment.FileName).Replace(".", "");
                if (!utilities.ValidDocumentExtension(extension))
                {
                    ModelState.AddModelError("", "Only text file types are allowed (doc, docx, odt, pdf)");

                    return PartialView(GetTasksViewPath("_AmbassadorDocument"), model);
                }
                var fileUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Attachment, MEDIA_DOC_FOLDER_ID, "File");

                member.SetValue(Ambassador.GetModelPropertyType(p => p.BioAttachment).Alias, fileUdi);
                Current.Services.MemberService.Save(member);

                Ambassador memberProfile = Members.GetById(model.MemberId) as Ambassador;
                model.FileUrl = memberProfile.BioAttachment.Url();
                model.FileName = memberProfile.BioAttachment.Name;

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Attachment.FileName);
            }
            return PartialView(GetTasksViewPath("_AmbassadorDocument"), model);
        }

        #endregion

        #region EMPLOYER PROFILE

        public ActionResult EmployerDetail()
        {
            Employer memberProfile = Members.GetById(loggedMember.MemberId) as Employer;
            EmployerProfileModel model = GetEmployerModel(memberProfile);

            return PartialView(GetTasksViewPath("_EmployerDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitEmployerDetail(EmployerProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                member.SetValue(Employer.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                member.SetValue(Employer.GetModelPropertyType(p => p.CompanyName).Alias, model.CompanyName);
                member.SetValue(Employer.GetModelPropertyType(p => p.ContactPerson).Alias, model.ContactPerson);
                member.SetValue(Employer.GetModelPropertyType(p => p.Headquarters).Alias, model.Headquarters);
                member.SetValue(Employer.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                member.SetValue(Employer.GetModelPropertyType(p => p.JobSector1).Alias, JsonConvert.SerializeObject(new[] { model.JobSector1 }));
                member.SetValue(Employer.GetModelPropertyType(p => p.JobSector2).Alias, JsonConvert.SerializeObject(new[] { model.JobSector2 }));
                member.SetValue(Employer.GetModelPropertyType(p => p.JobSector3).Alias, JsonConvert.SerializeObject(new[] { model.JobSector3 }));
                member.SetValue(Employer.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                member.SetValue(Employer.GetModelPropertyType(p => p.Website).Alias, model.Website);
                member.SetValue(Employer.GetModelPropertyType(p => p.SocialMedia).Alias, model.SocialMedia);

                Current.Services.MemberService.Save(member);

                IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
                model.CountryList = countries;
                model.JobSectorList = jobsectors;

                ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
            return PartialView(GetTasksViewPath("_EmployerDetail"), model);
        }

        public ActionResult EmployerImage(int memberId)
        {
            Employer memberProfile = Members.GetById(memberId) as Employer;
            MemberImageModel model = new MemberImageModel();

            string mediaUrl = memberProfile.Avatar != null ? memberProfile.Avatar.Url() : "";

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.ImageUrl = mediaUrl;
            }
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_EmployerImage"), model);
        }

        public ActionResult SubmitEmployerImage(MemberImageModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Avatar != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Avatar.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_EmployerImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Avatar, MEDIA_AVATAR_FOLDER_ID, "Image");

                member.SetValue(Employer.GetModelPropertyType(p => p.Avatar).Alias, imageUdi);
                Current.Services.MemberService.Save(member);

                Employer memberProfile = Members.GetById(model.MemberId) as Employer;
                model.ImageUrl = memberProfile.Avatar.Url();

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Avatar.FileName);
            }
            return PartialView(GetTasksViewPath("_EmployerImage"), model);
        }

        public ActionResult EmployerSummary(int memberId)
        {
            Employer memberProfile = Members.GetById(memberId) as Employer;
            EmployerProfileModel model = new EmployerProfileModel();

            model.CompanyInfo = new HtmlString(memberProfile.CompanyInfo.ToString());
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_EmployerSummary"), model);
        }

        public ActionResult EmployerSummarySave(string htmlText, int memberId)
        {
            string msg = "The content of the company info was successfully saved.";

            EmployerProfileModel model = new EmployerProfileModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            model.CompanyInfo = new HtmlString(htmlValue);

            var member = Current.Services.MemberService.GetById(memberId);

            member.SetValue(Employer.GetModelPropertyType(p => p.CompanyInfo).Alias, model.CompanyInfo);
            Current.Services.MemberService.Save(member);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region GRADUATE PROFILE

        public ActionResult GraduateDetail()
        {
            Graduate memberProfile = Members.GetById(loggedMember.MemberId) as Graduate;
            GraduateProfileModel model = GetGraduateModel(memberProfile);

            return PartialView(GetTasksViewPath("_GraduateDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitGraduateDetail(GraduateProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                    member.SetValue(CM.Graduate.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                    member.SetValue(CM.Graduate.GetModelPropertyType(p => p.FullName).Alias, model.FullName);
                    member.SetValue(CM.Graduate.GetModelPropertyType(p => p.BirthDate).Alias, model.BirthDate);
                    member.SetValue(CM.Graduate.GetModelPropertyType(p => p.Gender).Alias, JsonConvert.SerializeObject(new[] { model.Gender }));
                    member.SetValue(CM.Graduate.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                    member.SetValue(CM.Graduate.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                    member.SetValue(CM.Graduate.GetModelPropertyType(p => p.Specialization).Alias, JsonConvert.SerializeObject(new[] { model.Specialization }));
                    member.SetValue(CM.Graduate.GetModelPropertyType(p => p.School).Alias, model.School);

                    Current.Services.MemberService.Save(member);

                    IEnumerable<SelectListItem> genders = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Genders", null);
                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    IEnumerable<SelectListItem> eidikotites = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Specializations", null);
                    model.GenderList = genders;
                    model.CountryList = countries;
                    model.SpecializationList = eidikotites;

                    ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
            return PartialView(GetTasksViewPath("_GraduateDetail"), model);
        }

        public ActionResult GraduateImage(int memberId)
        {
            Graduate memberProfile = Members.GetById(memberId) as Graduate;
            MemberImageModel model = new MemberImageModel();

            string mediaUrl = memberProfile.Avatar != null ? memberProfile.Avatar.Url() : "";

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.ImageUrl = mediaUrl;
            }
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_GraduateImage"), model);
        }

        public ActionResult SubmitGraduateImage(MemberImageModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Avatar != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Avatar.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_GraduateImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Avatar, MEDIA_AVATAR_FOLDER_ID, "Image");

                member.SetValue(Graduate.GetModelPropertyType(p => p.Avatar).Alias, imageUdi);
                Current.Services.MemberService.Save(member);

                Graduate memberProfile = Members.GetById(model.MemberId) as Graduate;
                model.ImageUrl = memberProfile.Avatar.Url();

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Avatar.FileName);
            }
            return PartialView(GetTasksViewPath("_GraduateImage"), model);
        }

        public ActionResult GraduateSummary(int memberId)
        {
            Graduate memberProfile = Members.GetById(memberId) as Graduate;
            GraduateProfileModel model = new GraduateProfileModel();

            model.BioSummary = new HtmlString(memberProfile.BioSummary.ToString());
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_GraduateSummary"), model);
        }

        public ActionResult GraduateSummarySave(string htmlText, int memberId)
        {
            string msg = "The content of the bio summary was successfully saved.";

            GraduateProfileModel model = new GraduateProfileModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            model.BioSummary = new HtmlString(htmlValue);

            var member = Current.Services.MemberService.GetById(memberId);

            member.SetValue(Graduate.GetModelPropertyType(p => p.BioSummary).Alias, model.BioSummary);
            Current.Services.MemberService.Save(member);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GraduateDocument(int memberId)
        {
            Graduate memberProfile = Members.GetById(memberId) as Graduate;
            MemberDocumentModel model = new MemberDocumentModel();

            string mediaUrl = memberProfile.BioAttachment != null ? memberProfile.BioAttachment.Url() : "";

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.FileUrl = mediaUrl;
            }
            model.MemberId = memberId;
            model.FileName = memberProfile.BioAttachment != null ? memberProfile.BioAttachment.Name : "";

            return PartialView(GetTasksViewPath("_GraduateDocument"), model);
        }

        public ActionResult SubmitGraduateFile(MemberDocumentModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Attachment != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Attachment.FileName).Replace(".", "");
                if (!utilities.ValidDocumentExtension(extension))
                {
                    ModelState.AddModelError("", "Only text file types are allowed (doc, docx, odt, pdf)");

                    return PartialView(GetTasksViewPath("_GraduateDocument"), model);
                }
                var fileUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Attachment, MEDIA_DOC_FOLDER_ID, "File");

                member.SetValue(Graduate.GetModelPropertyType(p => p.BioAttachment).Alias, fileUdi);
                Current.Services.MemberService.Save(member);

                Graduate memberProfile = Members.GetById(model.MemberId) as Graduate;
                model.FileUrl = memberProfile.BioAttachment.Url();
                model.FileName = memberProfile.BioAttachment.Name;

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Attachment.FileName);
            }
            return PartialView(GetTasksViewPath("_GraduateDocument"), model);
        }

        #endregion

        #region LIAISON PROFILE

        public ActionResult LiaisonDetail()
        {
            Liaison memberProfile = Members.GetById(loggedMember.MemberId) as Liaison;
            LiaisonProfileModel model = GetLiaisonModel(memberProfile);

            return PartialView(GetTasksViewPath("_LiaisonDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitLiaisonDetail(LiaisonProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                member.SetValue(CM.Liaison.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                member.SetValue(CM.Liaison.GetModelPropertyType(p => p.FullName).Alias, model.FullName);
                member.SetValue(CM.Liaison.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                member.SetValue(CM.Liaison.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                member.SetValue(CM.Liaison.GetModelPropertyType(p => p.OfficeAddress).Alias, model.OfficeAddress);
                member.SetValue(CM.Liaison.GetModelPropertyType(p => p.Occupation).Alias, model.Occupation);
                member.SetValue(CM.Liaison.GetModelPropertyType(p => p.Employer).Alias, model.Employer);

                Current.Services.MemberService.Save(member);

                IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                model.CountryList = countries;

                ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
            return PartialView(GetTasksViewPath("_LiaisonDetail"), model);
        }

        public ActionResult LiaisonImage(int memberId)
        {
            Liaison memberProfile = Members.GetById(memberId) as Liaison;
            MemberImageModel model = new MemberImageModel();

            string mediaUrl = memberProfile.Avatar != null ? memberProfile.Avatar.Url() : "";

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.ImageUrl = mediaUrl;
            }
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_LiaisonImage"), model);
        }

        public ActionResult SubmitLiaisonImage(MemberImageModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Avatar != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Avatar.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_LiaisonImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Avatar, MEDIA_AVATAR_FOLDER_ID, "Image");

                member.SetValue(Liaison.GetModelPropertyType(p => p.Avatar).Alias, imageUdi);
                Current.Services.MemberService.Save(member);

                Liaison memberProfile = Members.GetById(model.MemberId) as Liaison;
                model.ImageUrl = memberProfile.Avatar.Url();

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Avatar.FileName);
            }
            return PartialView(GetTasksViewPath("_LiaisonImage"), model);
        }

        public ActionResult LiaisonSummary(int memberId)
        {
            Liaison memberProfile = Members.GetById(memberId) as Liaison;
            LiaisonProfileModel model = new LiaisonProfileModel();

            model.BioSummary = new HtmlString(memberProfile.BioSummary.ToString());
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_LiaisonSummary"), model);
        }

        public ActionResult LiaisonSummarySave(string htmlText, int memberId)
        {
            string msg = "The content of the bio summary was successfully saved.";

            LiaisonProfileModel model = new LiaisonProfileModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            model.BioSummary = new HtmlString(htmlValue);

            var member = Current.Services.MemberService.GetById(memberId);

            member.SetValue(Liaison.GetModelPropertyType(p => p.BioSummary).Alias, model.BioSummary);
            Current.Services.MemberService.Save(member);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region ORGANIZATION PROFILE

        public ActionResult OrganizationDetail()
        {
            Organization memberProfile = Members.GetById(loggedMember.MemberId) as Organization;
            OrganizationProfileModel model = GetOrganizationModel(memberProfile);

            return PartialView(GetTasksViewPath("_OrganizationDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitOrganizationDetail(OrganizationProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.OrganizationName).Alias, model.OrganizationName);
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.ContactPerson).Alias, model.ContactPerson);
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.Headquarters).Alias, model.Headquarters);
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.JobSector).Alias, JsonConvert.SerializeObject(new[] { model.JobSector }));
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.Website).Alias, model.Website);
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.SocialMedia).Alias, model.SocialMedia);

                Current.Services.MemberService.Save(member);

                IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
                model.CountryList = countries;
                model.JobSectorList = jobsectors;

                ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
            return PartialView(GetTasksViewPath("_OrganizationDetail"), model);
        }

        public ActionResult OrganizationImage(int memberId)
        {
            Organization memberProfile = Members.GetById(memberId) as Organization;
            MemberImageModel model = new MemberImageModel();

            string mediaUrl = memberProfile.Avatar != null ? memberProfile.Avatar.Url() : "";

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.ImageUrl = mediaUrl;
            }
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_OrganizationImage"), model);
        }

        public ActionResult SubmitOrganizationImage(MemberImageModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Avatar != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Avatar.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_OrganizationImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Avatar, MEDIA_AVATAR_FOLDER_ID, "Image");

                member.SetValue(Organization.GetModelPropertyType(p => p.Avatar).Alias, imageUdi);
                Current.Services.MemberService.Save(member);

                Organization memberProfile = Members.GetById(model.MemberId) as Organization;
                model.ImageUrl = memberProfile.Avatar.Url();

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Avatar.FileName);
            }
            return PartialView(GetTasksViewPath("_OrganizationImage"), model);
        }

        public ActionResult OrganizationSummary(int memberId)
        {
            Organization memberProfile = Members.GetById(memberId) as Organization;
            OrganizationProfileModel model = new OrganizationProfileModel();

            model.OrganizationInfo = new HtmlString(memberProfile.OrganizationInfo.ToString());
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_OrganizationSummary"), model);
        }

        public ActionResult OrganizationSummarySave(string htmlText, int memberId)
        {
            string msg = "The content of the organization info was successfully saved.";

            OrganizationProfileModel model = new OrganizationProfileModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            model.OrganizationInfo = new HtmlString(htmlValue);

            var member = Current.Services.MemberService.GetById(memberId);

            member.SetValue(Organization.GetModelPropertyType(p => p.OrganizationInfo).Alias, model.OrganizationInfo);
            Current.Services.MemberService.Save(member);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region SCHOOL PROFILE

        public ActionResult SchoolDetail()
        {
            School memberProfile = Members.GetById(loggedMember.MemberId) as School;
            SchoolProfileModel model = GetSchoolModel(memberProfile);

            return PartialView(GetTasksViewPath("_SchoolDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitSchoolDetail(SchoolProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                member.SetValue(School.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                member.SetValue(School.GetModelPropertyType(p => p.SchoolName).Alias, model.SchoolName);
                member.SetValue(School.GetModelPropertyType(p => p.ContactPerson).Alias, model.ContactPerson);
                member.SetValue(School.GetModelPropertyType(p => p.Address).Alias, model.Address);
                member.SetValue(School.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                member.SetValue(School.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                member.SetValue(School.GetModelPropertyType(p => p.Website).Alias, model.Website);
                member.SetValue(School.GetModelPropertyType(p => p.SocialMedia).Alias, model.SocialMedia);

                Current.Services.MemberService.Save(member);

                IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                model.CountryList = countries;

                ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
            return PartialView(GetTasksViewPath("_SchoolDetail"), model);
        }

        public ActionResult SchoolImage(int memberId)
        {
            School memberProfile = Members.GetById(memberId) as School;
            MemberImageModel model = new MemberImageModel();

            string mediaUrl = memberProfile.Avatar != null ? memberProfile.Avatar.Url() : "";

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.ImageUrl = mediaUrl;
            }
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_SchoolImage"), model);
        }

        public ActionResult SubmitSchoolImage(MemberImageModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Avatar != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Avatar.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_SchoolImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Avatar, MEDIA_AVATAR_FOLDER_ID, "Image");

                member.SetValue(School.GetModelPropertyType(p => p.Avatar).Alias, imageUdi);
                Current.Services.MemberService.Save(member);

                School memberProfile = Members.GetById(model.MemberId) as School;
                model.ImageUrl = memberProfile.Avatar.Url();

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Avatar.FileName);
            }
            return PartialView(GetTasksViewPath("_SchoolImage"), model);
        }

        public ActionResult SchoolSummary(int memberId)
        {
            School memberProfile = Members.GetById(memberId) as School;
            SchoolProfileModel model = new SchoolProfileModel();

            model.SchoolInfo = new HtmlString(memberProfile.SchoolInfo.ToString());
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_SchoolSummary"), model);
        }

        public ActionResult SchoolSummarySave(string htmlText, int memberId)
        {
            string msg = "The content of the school info was successfully saved.";

            SchoolProfileModel model = new SchoolProfileModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            model.SchoolInfo = new HtmlString(htmlValue);

            var member = Current.Services.MemberService.GetById(memberId);

            member.SetValue(School.GetModelPropertyType(p => p.SchoolInfo).Alias, model.SchoolInfo);
            Current.Services.MemberService.Save(member);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region STUDENT PROFILE

        public ActionResult StudentDetail()
        {
            Student memberProfile = Members.GetById(loggedMember.MemberId) as Student;
            StudentProfileModel model = GetStudentModel(memberProfile);

            return PartialView(GetTasksViewPath("_StudentDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitStudentDetail(StudentProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                member.SetValue(CM.Student.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                member.SetValue(CM.Student.GetModelPropertyType(p => p.FullName).Alias, model.FullName);
                member.SetValue(CM.Student.GetModelPropertyType(p => p.BirthDate).Alias, model.BirthDate);
                member.SetValue(CM.Student.GetModelPropertyType(p => p.Gender).Alias, JsonConvert.SerializeObject(new[] { model.Gender }));
                member.SetValue(CM.Student.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                member.SetValue(CM.Student.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                member.SetValue(CM.Student.GetModelPropertyType(p => p.Specialization).Alias, JsonConvert.SerializeObject(new[] { model.Specialization }));
                member.SetValue(CM.Student.GetModelPropertyType(p => p.School).Alias, model.School);

                Current.Services.MemberService.Save(member);

                IEnumerable<SelectListItem> genders = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Genders", null);
                IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                IEnumerable<SelectListItem> eidikotites = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Specializations", null);
                model.GenderList = genders;
                model.CountryList = countries;
                model.SpecializationList = eidikotites;

                ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
            return PartialView(GetTasksViewPath("_StudentDetail"), model);
        }

        public ActionResult StudentImage(int memberId)
        {
            Student memberProfile = Members.GetById(memberId) as Student;
            MemberImageModel model = new MemberImageModel();

            string mediaUrl = memberProfile.Avatar != null ? memberProfile.Avatar.Url() : "";

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.ImageUrl = mediaUrl;
            }
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_StudentImage"), model);
        }

        public ActionResult SubmitStudentImage(MemberImageModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Avatar != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Avatar.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_StudentImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Avatar, MEDIA_AVATAR_FOLDER_ID, "Image");

                member.SetValue(Student.GetModelPropertyType(p => p.Avatar).Alias, imageUdi);
                Current.Services.MemberService.Save(member);

                Student memberProfile = Members.GetById(model.MemberId) as Student;
                model.ImageUrl = memberProfile.Avatar.Url();

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Avatar.FileName);
            }
            return PartialView(GetTasksViewPath("_StudentImage"), model);
        }

        public ActionResult StudentSummary(int memberId)
        {
            Student memberProfile = Members.GetById(memberId) as Student;
            StudentProfileModel model = new StudentProfileModel();

            model.BioSummary = new HtmlString(memberProfile.BioSummary.ToString());
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_StudentSummary"), model);
        }

        public ActionResult StudentSummarySave(string htmlText, int memberId)
        {
            string msg = "The content of the bio summary was successfully saved.";

            StudentProfileModel model = new StudentProfileModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            model.BioSummary = new HtmlString(htmlValue);

            var member = Current.Services.MemberService.GetById(memberId);

            member.SetValue(Student.GetModelPropertyType(p => p.BioSummary).Alias, model.BioSummary);
            Current.Services.MemberService.Save(member);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region TEACHER PROFILE

        public ActionResult TeacherDetail()
        {
            Teacher memberProfile = Members.GetById(loggedMember.MemberId) as Teacher;
            TeacherProfileModel model = GetTeacherModel(memberProfile);

            return PartialView(GetTasksViewPath("_TeacherDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitTeacherDetail(TeacherProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                member.SetValue(CM.Teacher.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                member.SetValue(CM.Teacher.GetModelPropertyType(p => p.FullName).Alias, model.FullName);
                member.SetValue(CM.Teacher.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                member.SetValue(CM.Teacher.GetModelPropertyType(p => p.School).Alias, model.School);
                member.SetValue(CM.Teacher.GetModelPropertyType(p => p.SchoolAddress).Alias, model.SchoolAddress);
                member.SetValue(CM.Teacher.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                member.SetValue(CM.Teacher.GetModelPropertyType(p => p.SocialMedia).Alias, model.SocialMedia);

                Current.Services.MemberService.Save(member);

                IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                model.CountryList = countries;

                ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
            return PartialView(GetTasksViewPath("_TeacherDetail"), model);
        }

        public ActionResult TeacherImage(int memberId)
        {
            Teacher memberProfile = Members.GetById(memberId) as Teacher;
            MemberImageModel model = new MemberImageModel();

            string mediaUrl = memberProfile.Avatar != null ? memberProfile.Avatar.Url() : "";

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.ImageUrl = mediaUrl;
            }
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_TeacherImage"), model);
        }

        public ActionResult SubmitTeacherImage(MemberImageModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Avatar != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Avatar.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_TeacherImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Avatar, MEDIA_AVATAR_FOLDER_ID, "Image");

                member.SetValue(Teacher.GetModelPropertyType(p => p.Avatar).Alias, imageUdi);
                Current.Services.MemberService.Save(member);

                Teacher memberProfile = Members.GetById(model.MemberId) as Teacher;
                model.ImageUrl = memberProfile.Avatar.Url();

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Avatar.FileName);
            }
            return PartialView(GetTasksViewPath("_TeacherImage"), model);
        }

        public ActionResult TeacherSummary(int memberId)
        {
            Teacher memberProfile = Members.GetById(memberId) as Teacher;
            TeacherProfileModel model = new TeacherProfileModel();

            model.BioSummary = new HtmlString(memberProfile.BioSummary.ToString());
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_TeacherSummary"), model);
        }

        public ActionResult TeacherSummarySave(string htmlText, int memberId)
        {
            string msg = "The content of the bio summary was successfully saved.";

            TeacherProfileModel model = new TeacherProfileModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            model.BioSummary = new HtmlString(htmlValue);

            var member = Current.Services.MemberService.GetById(memberId);

            member.SetValue(Teacher.GetModelPropertyType(p => p.BioSummary).Alias, model.BioSummary);
            Current.Services.MemberService.Save(member);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region MEMBER PROFILE

        public ActionResult MemberDetail()
        {
            CM.Member memberProfile = Members.GetById(loggedMember.MemberId) as CM.Member;
            MemberProfileModel model = GetMemberModel(memberProfile);

            return PartialView(GetTasksViewPath("_MemberDetail"), model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitMemberDetail(MemberProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                member.SetValue(CM.Member.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                member.SetValue(CM.Member.GetModelPropertyType(p => p.FullName).Alias, model.FullName);
                member.SetValue(CM.Member.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                member.SetValue(CM.Member.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                member.SetValue(CM.Member.GetModelPropertyType(p => p.SocialMedia).Alias, model.SocialMedia);
                member.SetValue(CM.Member.GetModelPropertyType(p => p.Occupation).Alias, model.Occupation);

                Current.Services.MemberService.Save(member);

                IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                model.CountryList = countries;

                ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
            return PartialView(GetTasksViewPath("_MemberDetail"), model);
        }

        public ActionResult MemberImage(int memberId)
        {
            CM.Member memberProfile = Members.GetById(memberId) as CM.Member;
            MemberImageModel model = new MemberImageModel();

            string mediaUrl = memberProfile.Avatar != null ? memberProfile.Avatar.Url() : "";

            if (!string.IsNullOrEmpty(mediaUrl))
            {
                model.ImageUrl = mediaUrl;
            }
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_MemberImage"), model);
        }

        public ActionResult SubmitMemberImage(MemberImageModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (model.Avatar != null && ModelState.IsValid)
            {
                string extension = Path.GetExtension(model.Avatar.FileName).Replace(".", "");
                if (!utilities.ValidImageFileExtension(extension))
                {
                    ModelState.AddModelError("", "Only image file types are allowed (png, jpg, jpeg, gif, webp, tiff)");

                    return PartialView(GetTasksViewPath("_MemberImage"), model);
                }
                var imageUdi = _mediaUploadService.CreateMediaItemFromFileUpload(model.Avatar, MEDIA_AVATAR_FOLDER_ID, "Image");

                member.SetValue(CM.Member.GetModelPropertyType(p => p.Avatar).Alias, imageUdi);
                Current.Services.MemberService.Save(member);

                CM.Member memberProfile = Members.GetById(model.MemberId) as CM.Member;
                model.ImageUrl = memberProfile.Avatar.Url();

                ViewData["successMessage"] = string.Format(" The file <b><i>{0}</i></b> was succesfully uploaded.<br />", model.Avatar.FileName);
            }
            return PartialView(GetTasksViewPath("_MemberImage"), model);
        }

        public ActionResult MemberSummary(int memberId)
        {
            CM.Member memberProfile = Members.GetById(memberId) as CM.Member;
            MemberProfileModel model = new MemberProfileModel();

            model.BioSummary = new HtmlString(memberProfile.BioSummary.ToString());
            model.MemberId = memberId;

            return PartialView(GetTasksViewPath("_MemberSummary"), model);
        }

        public ActionResult MemberSummarySave(string htmlText, int memberId)
        {
            string msg = "The content of the bio summary was successfully saved.";

            MemberProfileModel model = new MemberProfileModel();

            string htmlValue = JsonConvert.DeserializeObject(htmlText).ToString();
            model.BioSummary = new HtmlString(htmlValue);

            var member = Current.Services.MemberService.GetById(memberId);

            member.SetValue(CM.Member.GetModelPropertyType(p => p.BioSummary).Alias, model.BioSummary);
            Current.Services.MemberService.Save(member);

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion


        #region MEMBERS MODEL GETTERS

        public AmbassadorProfileModel GetAmbassadorModel(Ambassador memberProfile)
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
            IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);

            AmbassadorProfileModel memberModel = new AmbassadorProfileModel()
            {
                MemberId = memberProfile.Id,
                FullName = memberProfile.Name,
                TaxNumber = memberProfile.TaxNumber,
                Address = memberProfile.Address,
                Country = memberProfile.Country,
                Phone = memberProfile.Phone,
                Website = memberProfile.Website,
                SocialMedia = memberProfile.SocialMedia,
                Occupation = memberProfile.Occupation,
                JobSector = memberProfile.JobSector,
                Employer = memberProfile.Employer,
                CountryList = countries,
                JobSectorList = jobsectors
            };

            return memberModel;
        }

        public EmployerProfileModel GetEmployerModel(CM.Employer memberProfile)
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
            IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);

            EmployerProfileModel memberModel = new EmployerProfileModel()
            {
                MemberId = memberProfile.Id,
                CompanyName = memberProfile.Name,
                TaxNumber = memberProfile.TaxNumber,
                ContactPerson = memberProfile.ContactPerson,
                Headquarters = memberProfile.Headquarters,
                Country = memberProfile.Country,
                JobSector1 = memberProfile.JobSector1,
                JobSector2 = memberProfile.JobSector2,
                JobSector3 = memberProfile.JobSector3,
                Phone = memberProfile.Phone,
                Website = memberProfile.Website,
                SocialMedia = memberProfile.SocialMedia,
                CountryList = countries,
                JobSectorList = jobsectors
            };

            return memberModel;
        }

        public GraduateProfileModel GetGraduateModel(CM.Graduate memberProfile)
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> genders = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Genders", null);
            IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
            IEnumerable<SelectListItem> eidikotites = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Specializations", null);

            GraduateProfileModel memberModel = new GraduateProfileModel()
            {
                MemberId = memberProfile.Id,
                FullName = memberProfile.Name,
                TaxNumber = memberProfile.TaxNumber,
                BirthDate = memberProfile.BirthDate,
                Gender = memberProfile.Gender,
                Phone = memberProfile.Phone,
                Country = memberProfile.Country,
                Specialization = memberProfile.Specialization,
                School = memberProfile.School,
                GenderList = genders,
                CountryList = countries,
                SpecializationList = eidikotites
            };

            return memberModel;
        }

        public LiaisonProfileModel GetLiaisonModel(CM.Liaison memberProfile)
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);

            LiaisonProfileModel memberModel = new LiaisonProfileModel()
            {
                MemberId = memberProfile.Id,
                FullName = memberProfile.Name,
                TaxNumber = memberProfile.TaxNumber,
                Country = memberProfile.Country,
                Phone = memberProfile.Phone,
                OfficeAddress = memberProfile.OfficeAddress,
                Occupation = memberProfile.Occupation,
                Employer = memberProfile.Employer,
                CountryList = countries
            };

            return memberModel;
        }

        public OrganizationProfileModel GetOrganizationModel(CM.Organization memberProfile)
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
            IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);

            OrganizationProfileModel memberModel = new OrganizationProfileModel()
            {
                MemberId = memberProfile.Id,
                TaxNumber = memberProfile.TaxNumber,
                OrganizationName = memberProfile.Name,
                ContactPerson = memberProfile.ContactPerson,
                Country = memberProfile.Country,
                Headquarters = memberProfile.Headquarters,
                JobSector = memberProfile.JobSector,
                Phone = memberProfile.Phone,
                Website = memberProfile.Website,
                SocialMedia = memberProfile.SocialMedia,
                CountryList = countries,
                JobSectorList = jobsectors
            };

            return memberModel;
        }

        public SchoolProfileModel GetSchoolModel(CM.School memberProfile)
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);

            SchoolProfileModel memberModel = new SchoolProfileModel()
            {
                MemberId = memberProfile.Id,
                TaxNumber = memberProfile.TaxNumber,
                SchoolName = memberProfile.Name,
                ContactPerson = memberProfile.ContactPerson,
                Address = memberProfile.Address,
                Country = memberProfile.Country,
                Phone = memberProfile.Phone,
                Website = memberProfile.Website,
                SocialMedia = memberProfile.SocialMedia,
                CountryList = countries
            };

            return memberModel;
        }

        public StudentProfileModel GetStudentModel(CM.Student memberProfile)
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> genders = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Genders", null);
            IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
            IEnumerable<SelectListItem> eidikotites = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Specializations", null);

            StudentProfileModel memberModel = new StudentProfileModel()
            {
                MemberId = memberProfile.Id,
                TaxNumber = memberProfile.TaxNumber,
                FullName = memberProfile.Name,
                BirthDate = memberProfile.BirthDate,
                Gender = memberProfile.Gender,
                Phone = memberProfile.Phone,
                Country = memberProfile.Country,
                Specialization = memberProfile.Specialization,
                School = memberProfile.School,
                GenderList = genders,
                CountryList = countries,
                SpecializationList = eidikotites
            };

            return memberModel;
        }

        public TeacherProfileModel GetTeacherModel(CM.Teacher memberProfile)
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);

            TeacherProfileModel memberModel = new TeacherProfileModel()
            {
                MemberId = memberProfile.Id,
                TaxNumber = memberProfile.TaxNumber,
                FullName = memberProfile.Name,
                Country = memberProfile.Country,
                School = memberProfile.School,
                SchoolAddress = memberProfile.SchoolAddress,
                Phone = memberProfile.Phone,
                SocialMedia = memberProfile.SocialMedia,
                CountryList = countries
            };

            return memberModel;
        }

        public MemberProfileModel GetMemberModel(CM.Member memberProfile)
        {
            // Get data source for dropdown list in the partial View
            IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);

            MemberProfileModel memberModel = new MemberProfileModel()
            {
                MemberId = memberProfile.Id,
                TaxNumber = memberProfile.TaxNumber,
                FullName = memberProfile.FullName,
                Country = memberProfile.Country,
                Phone = memberProfile.Phone,
                SocialMedia = memberProfile.SocialMedia,
                Occupation = memberProfile.Occupation,
                CountryList = countries
            };

            return memberModel;
        }

        #endregion

        [HttpPost]
        public ActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }
    }
}