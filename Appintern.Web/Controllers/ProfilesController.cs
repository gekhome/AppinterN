using Appintern.Core.Services;
using Appintern.Web.Library;
using Appintern.Web.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Composing;
using Umbraco.Core.Logging;
using Umbraco.Core.Persistence.Querying;
using Umbraco.Web.Mvc;
using CM = Umbraco.Web.PublishedModels;

namespace Appintern.Web.Controllers
{
    public class ProfilesController : SurfaceController
    {
        private readonly Utilities utilities = new Utilities();
        private readonly ILogger _logger;
        private readonly IDataTypeValueService _dataTypeValueService;

        public ProfilesController(ILogger logger, IDataTypeValueService dataTypeValueService)
        {
            _logger = logger;
            _dataTypeValueService = dataTypeValueService;
        }

        private string GetMemberViewPath(string name)
        {
            return $"~/Views/Partials/Member/{name}.cshtml";
        }

        // Need this, otherwise throws exception 'action not found'
        // Alterantively, omitting the tag defaults to both
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult RenderMemberForm(string memberAlias, string memberType)
        {
            string memberForm;

            if (memberType == "member")
            {
                MemberProfileModel memberModel;
                memberForm = "_MemberProfile";
                memberModel = GetMemberProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), memberModel);
            }
            else if (memberType == "student")
            {
                StudentProfileModel studentModel;
                memberForm = "_StudentProfile";
                studentModel = GetStudentProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), studentModel);
            }
            else if (memberType == "graduate")
            {
                GraduateProfileModel graduateModel;
                memberForm = "_GraduateProfile";
                graduateModel = GetGraduateProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), graduateModel);
            }
            else if (memberType == "school")
            {
                SchoolProfileModel schoolModel;
                memberForm = "_SchoolProfile";
                schoolModel = GetSchoolProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), schoolModel);
            }
            else if (memberType == "teacher")
            {
                TeacherProfileModel teacherModel;
                memberForm = "_TeacherProfile";
                teacherModel = GetTeacherProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), teacherModel);
            }
            else if (memberType == "ambassador")
            {
                AmbassadorProfileModel ambassadorModel;
                memberForm = "_AmbassadorProfile";
                ambassadorModel = GetAmbassadorProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), ambassadorModel);
            }
            else if (memberType == "liaison")
            {
                LiaisonProfileModel liaisonModel;
                memberForm = "_LiaisonProfile";
                liaisonModel = GetLiaisonProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), liaisonModel);
            }
            else if (memberType == "organization")
            {
                OrganizationProfileModel organizationModel;
                memberForm = "_OrganizationProfile";
                organizationModel = GetOrganizationProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), organizationModel);
            }
            else if (memberType == "employer")
            {
                EmployerProfileModel employerModel;
                memberForm = "_EmployerProfile";
                employerModel = GetEmployerProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), employerModel);
            }
            else
            {
                MemberProfileModel memberModel;
                memberForm = "_MemberProfile";
                memberModel = GetMemberProfileModel(memberAlias);
                return PartialView(GetMemberViewPath(memberForm), memberModel);
            }
        }


        #region SUBMIT FORMS

        [ValidateAntiForgeryToken]
        public ActionResult SubmitAmbassadorForm(AmbassadorProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                try
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

                    return CurrentUmbracoPage();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);

                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
                    model.CountryList = countries;
                    model.JobSectorList = jobsectors;

                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitEmployerForm(EmployerProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                try
                {
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.CompanyName).Alias, model.CompanyName);
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.ContactPerson).Alias, model.ContactPerson);
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.Headquarters).Alias, model.Headquarters);
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.JobSector1).Alias, JsonConvert.SerializeObject(new[] { model.JobSector1 }));
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.JobSector2).Alias, JsonConvert.SerializeObject(new[] { model.JobSector2 }));
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.JobSector3).Alias, JsonConvert.SerializeObject(new[] { model.JobSector3 }));
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.Website).Alias, model.Website);
                    member.SetValue(CM.Employer.GetModelPropertyType(p => p.SocialMedia).Alias, model.SocialMedia);

                    Current.Services.MemberService.Save(member);

                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
                    model.CountryList = countries;
                    model.JobSectorList = jobsectors;

                    ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);

                    return CurrentUmbracoPage();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);

                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
                    model.CountryList = countries;
                    model.JobSectorList = jobsectors;

                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitGraduateForm(GraduateProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                try
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

                    return CurrentUmbracoPage();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);

                    IEnumerable<SelectListItem> genders = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Genders", null);
                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    IEnumerable<SelectListItem> eidikotites = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Specializations", null);
                    model.GenderList = genders;
                    model.CountryList = countries;
                    model.SpecializationList = eidikotites;

                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitLiaisonForm(LiaisonProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                try
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

                    return CurrentUmbracoPage();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);

                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    model.CountryList = countries;

                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitOrganizationForm(OrganizationProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                try
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

                    return CurrentUmbracoPage();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);

                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    IEnumerable<SelectListItem> jobsectors = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Job Sectors", null);
                    model.CountryList = countries;
                    model.JobSectorList = jobsectors;

                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitSchoolForm(SchoolProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                try
                {
                    member.SetValue(CM.School.GetModelPropertyType(p => p.TaxNumber).Alias, model.TaxNumber);
                    member.SetValue(CM.School.GetModelPropertyType(p => p.SchoolName).Alias, model.SchoolName);
                    member.SetValue(CM.School.GetModelPropertyType(p => p.ContactPerson).Alias, model.ContactPerson);
                    member.SetValue(CM.School.GetModelPropertyType(p => p.Address).Alias, model.Address);
                    member.SetValue(CM.School.GetModelPropertyType(p => p.Country).Alias, JsonConvert.SerializeObject(new[] { model.Country }));
                    member.SetValue(CM.School.GetModelPropertyType(p => p.Phone).Alias, model.Phone);
                    member.SetValue(CM.School.GetModelPropertyType(p => p.Website).Alias, model.Website);
                    member.SetValue(CM.School.GetModelPropertyType(p => p.SocialMedia).Alias, model.SocialMedia);

                    Current.Services.MemberService.Save(member);

                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    model.CountryList = countries;

                    ViewData["successMessage"] = "Your form was successfully submitted at " + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);

                    return CurrentUmbracoPage();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);

                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    model.CountryList = countries;

                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitStudentForm(StudentProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                try
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

                    return CurrentUmbracoPage();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);

                    IEnumerable<SelectListItem> genders = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Genders", null);
                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    IEnumerable<SelectListItem> eidikotites = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Specializations", null);
                    model.GenderList = genders;
                    model.CountryList = countries;
                    model.SpecializationList = eidikotites;

                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitTeacherForm(TeacherProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                try
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

                    return CurrentUmbracoPage();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);

                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    model.CountryList = countries;

                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }

        [ValidateAntiForgeryToken]
        public ActionResult SubmitMemberForm(MemberProfileModel model)
        {
            var member = Current.Services.MemberService.GetById(model.MemberId);

            if (member != null && ModelState.IsValid)
            {
                try
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

                    return CurrentUmbracoPage();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);

                    IEnumerable<SelectListItem> countries = _dataTypeValueService.GetItemsFromValueListDataType("Dropdown Countries", null);
                    model.CountryList = countries;

                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }

        #endregion

        #region GETTERS

        // View models getters
        public AmbassadorProfileModel GetAmbassadorModel(CM.Ambassador memberProfile)
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


        // Profile models getters
        public AmbassadorProfileModel GetAmbassadorProfileModel(string propertyValue)
        {
            var memberService = Current.Services.MemberService;

            var members = memberService.GetMembersByPropertyValue(CM.Ambassador.GetModelPropertyType(p => p.UrlSlug).Alias, propertyValue, StringPropertyMatchType.Exact);
            var memberProfile = Members.GetById(members.FirstOrDefault().Id) as CM.Ambassador;

            AmbassadorProfileModel memberModel = GetAmbassadorModel(memberProfile);

            return memberModel;
        }

        public EmployerProfileModel GetEmployerProfileModel(string propertyValue)
        {
            var memberService = Current.Services.MemberService;

            var members = memberService.GetMembersByPropertyValue(CM.Employer.GetModelPropertyType(p => p.UrlSlug).Alias, propertyValue, StringPropertyMatchType.Exact);
            var memberProfile = Members.GetById(members.FirstOrDefault().Id) as CM.Employer;

            EmployerProfileModel memberModel = GetEmployerModel(memberProfile);

            return memberModel;
        }

        public GraduateProfileModel GetGraduateProfileModel(string propertyValue)
        {
            var memberService = Current.Services.MemberService;

            var members = memberService.GetMembersByPropertyValue(CM.Graduate.GetModelPropertyType(p => p.UrlSlug).Alias, propertyValue, StringPropertyMatchType.Exact);
            var memberProfile = Members.GetById(members.FirstOrDefault().Id) as CM.Graduate;

            GraduateProfileModel memberModel = GetGraduateModel(memberProfile);

            return memberModel;
        }

        public LiaisonProfileModel GetLiaisonProfileModel(string propertyValue)
        {
            var memberService = Current.Services.MemberService;

            var members = memberService.GetMembersByPropertyValue(CM.Liaison.GetModelPropertyType(p => p.UrlSlug).Alias, propertyValue, StringPropertyMatchType.Exact);
            var memberProfile = Members.GetById(members.FirstOrDefault().Id) as CM.Liaison;

            LiaisonProfileModel memberModel = GetLiaisonModel(memberProfile);

            return memberModel;
        }

        public OrganizationProfileModel GetOrganizationProfileModel(string propertyValue)
        {
            var memberService = Current.Services.MemberService;

            var members = memberService.GetMembersByPropertyValue(CM.Organization.GetModelPropertyType(p => p.UrlSlug).Alias, propertyValue, StringPropertyMatchType.Exact);
            var memberProfile = Members.GetById(members.FirstOrDefault().Id) as CM.Organization;

            OrganizationProfileModel memberModel = GetOrganizationModel(memberProfile);

            return memberModel;
        }

        public SchoolProfileModel GetSchoolProfileModel(string propertyValue)
        {
            var memberService = Current.Services.MemberService;

            var members = memberService.GetMembersByPropertyValue(CM.School.GetModelPropertyType(p => p.UrlSlug).Alias, propertyValue, StringPropertyMatchType.Exact);
            var memberProfile = Members.GetById(members.FirstOrDefault().Id) as CM.School;

            SchoolProfileModel memberModel = GetSchoolModel(memberProfile);

            return memberModel;
        }

        public StudentProfileModel GetStudentProfileModel(string propertyValue)
        {
            var memberService = Current.Services.MemberService;

            var members = memberService.GetMembersByPropertyValue(CM.Student.GetModelPropertyType(p => p.UrlSlug).Alias, propertyValue, StringPropertyMatchType.Exact);
            var memberProfile = Members.GetById(members.FirstOrDefault().Id) as CM.Student;

            StudentProfileModel memberModel = GetStudentModel(memberProfile);

            return memberModel;
        }

        public TeacherProfileModel GetTeacherProfileModel(string propertyValue)
        {
            var memberService = Current.Services.MemberService;

            var members = memberService.GetMembersByPropertyValue(CM.Teacher.GetModelPropertyType(p => p.UrlSlug).Alias, propertyValue, StringPropertyMatchType.Exact);
            var memberProfile = Members.GetById(members.FirstOrDefault().Id) as CM.Teacher;

            TeacherProfileModel memberModel = GetTeacherModel(memberProfile);

            return memberModel;
        }

        public MemberProfileModel GetMemberProfileModel(string propertyValue)
        {
            var memberService = Current.Services.MemberService;

            var members = memberService.GetMembersByPropertyValue(CM.Member.GetModelPropertyType(p => p.UrlSlug).Alias, propertyValue, StringPropertyMatchType.Exact);
            var memberProfile = Members.GetById(members.FirstOrDefault().Id) as CM.Member;

            MemberProfileModel memberModel = GetMemberModel(memberProfile);

            return memberModel;
        }

        #endregion
    }
}