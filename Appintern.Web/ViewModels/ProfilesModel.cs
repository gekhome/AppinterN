using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Umbraco.Core.Models.PublishedContent;

namespace Appintern.Web.ViewModels
{
    public class AmbassadorProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Tax Number")]
        public string TaxNumber { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Social Media")]
        public string SocialMedia { get; set; }

        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        [Display(Name = "Employer")]
        public string Employer { get; set; }

        [Display(Name = "Bio Summary:")]
        public HtmlString BioSummary { get; set; }

        [Display(Name = "Bio Attachment")]
        public HttpPostedFileBase BioAttachment { get; set; }

        [Display(Name = "Bio Filename")]
        public string BioFileName { get; set; }

        [Display(Name = "Bio File Attachment:")]
        public string BioFileUrl { get; set; }

        [Display(Name = "Profile image")]
        public HttpPostedFileBase Avatar { get; set; }

        [Display(Name = "Avatar Url")]
        public string AvatarUrl { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }

    }

    public class EmployerProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Tax Number")]
        public string TaxNumber { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company name cannot be blank")]
        public string CompanyName { get; set; }

        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Display(Name = "Headquarters location")]
        public string Headquarters { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Job Sector 1")]
        [Required(ErrorMessage = "First job sector cannot be blank")]
        public string JobSector1 { get; set; }

        [Display(Name = "Job Sector 2")]
        public string JobSector2 { get; set; }

        [Display(Name = "Job Sector 3")]
        public string JobSector3 { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Social Media")]
        public string SocialMedia { get; set; }

        [Display(Name = "Company Information:")]
        public HtmlString CompanyInfo { get; set; }

        [Display(Name = "Profile image")]
        public HttpPostedFileBase Avatar { get; set; }

        [Display(Name = "Avatar Url")]
        public string AvatarUrl { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }

    }

    public class GraduateProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Tax Number")]
        public string TaxNumber { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        public string Gender { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Specialization")]
        public string Specialization { get; set; }

        [Display(Name = "School")]
        public string School { get; set; }

        [Display(Name = "Bio Summary:")]
        public HtmlString BioSummary { get; set; }

        [Display(Name = "Bio Attachment")]
        public HttpPostedFileBase BioAttachment { get; set; }

        [Display(Name = "Bio Filename")]
        public string BioFileName { get; set; }

        [Display(Name = "Bio File Attachment:")]
        public string BioFileUrl { get; set; }

        [Display(Name = "Profile image")]
        public HttpPostedFileBase Avatar { get; set; }

        [Display(Name = "Avatar Url")]
        public string AvatarUrl { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> GenderList { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> SpecializationList { get; set; }
    }

    public class LiaisonProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Tax Number")]
        public string TaxNumber { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Office Address")]
        public string OfficeAddress { get; set; }

        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [Display(Name = "Employer")]
        public string Employer { get; set; }

        [Display(Name = "Bio Summary:")]
        public HtmlString BioSummary { get; set; }

        [Display(Name = "Profile image")]
        public HttpPostedFileBase Avatar { get; set; }

        [Display(Name = "Avatar Url")]
        public string AvatarUrl { get; set; }

        public string UrlSlug { get; set; }
        
        public IEnumerable<SelectListItem> CountryList { get; set; }

    }

    public class OrganizationProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Tax Number")]
        public string TaxNumber { get; set; }

        [Display(Name = "Organization Name")]
        [Required(ErrorMessage = "Organization name cannot be blank")]
        public string OrganizationName { get; set; }

        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Headquarters location")]
        public string Headquarters { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Social Media")]
        public string SocialMedia { get; set; }

        [Display(Name = "Organization Summary:")]
        public HtmlString OrganizationInfo { get; set; }

        [Display(Name = "Profile image")]
        public HttpPostedFileBase Avatar { get; set; }

        [Display(Name = "Avatar Url")]
        public string AvatarUrl { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }

    }

    public class SchoolProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Tax Number")]
        public string TaxNumber { get; set; }

        [Display(Name = "School Name")]
        [Required(ErrorMessage = "School name cannot be blank")]
        public string SchoolName { get; set; }

        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Phone number cannot be blank")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Social Media")]
        public string SocialMedia { get; set; }

        [Display(Name = "School Summary:")]
        public HtmlString SchoolInfo { get; set; }

        [Display(Name = "Profile image")]
        public HttpPostedFileBase Avatar { get; set; }

        [Display(Name = "Avatar Url")]
        public string AvatarUrl { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> CountryList { get; set; }

    }

    public class StudentProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Tax Number")]
        public string TaxNumber { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/ΜΜ/yyyy}")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        public string Gender { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Specialization")]
        public string Specialization { get; set; }

        [Display(Name = "School")]
        public string School { get; set; }

        [Display(Name = "Bio Summary:")]
        public HtmlString BioSummary { get; set; }

        [Display(Name = "Profile image")]
        public HttpPostedFileBase Avatar { get; set; }

        [Display(Name = "Avatar Url")]
        public string AvatarUrl { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> GenderList { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> SpecializationList { get; set; }
    }

    public class TeacherProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Tax Number")]
        public string TaxNumber { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "School")]
        public string School { get; set; }

        [Display(Name = "School address")]
        public string SchoolAddress { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Social Media")]
        public string SocialMedia { get; set; }

        [Display(Name = "Bio Summary:")]
        public HtmlString BioSummary { get; set; }

        [Display(Name = "Profile image")]
        public HttpPostedFileBase Avatar { get; set; }

        [Display(Name = "Avatar Url")]
        public string AvatarUrl { get; set; }

        public string UrlSlug { get; set; }
        
        public IEnumerable<SelectListItem> CountryList { get; set; }
    }

    public class MemberProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Tax Number")]
        public string TaxNumber { get; set; }

        [Display(Name = "Full Name or Institution name or Tradename")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Social Media")]
        public string SocialMedia { get; set; }

        [Display(Name = "Occupation")]
        [Required(ErrorMessage ="Occupation cannot be blank")]
        public string Occupation { get; set; }

        [Display(Name = "Bio Summary:")]
        public HtmlString BioSummary { get; set; }

        [Display(Name = "Profile image")]
        public HttpPostedFileBase Avatar { get; set; }

        [Display(Name = "Avatar Url")]
        public string AvatarUrl { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> CountryList { get; set; }
    }

}