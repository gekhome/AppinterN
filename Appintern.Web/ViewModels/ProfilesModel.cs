using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Umbraco.Core.Models.PublishedContent;

namespace Appintern.Web.ViewModels
{
    public class MemberProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Full Name or Institution name or Tradename")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Address (street, city, country)")]
        public string Address { get; set; }

        [Display(Name = "Occupation")]
        [Required(ErrorMessage ="Occupation cannot be blank")]
        public string Occupation { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> JobSectorList { get; set; }
    }

    public class StudentProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        public string Gender { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State or Region")]
        public string State { get; set; }

        [Display(Name = "Postcode")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "School")]
        public string School { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        [Display(Name = "Studies Specialization")]
        public string Specialty { get; set; }

        [Display(Name = "Profile Image")]
        public IPublishedContent Avatar { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> GenderList { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }
    }

    public class GraduateProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        public string Gender { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State or Region")]
        public string State { get; set; }

        [Display(Name = "Postcode")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "School")]
        public string School { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        [Display(Name = "Studies Specialization")]
        public string Specialty { get; set; }

        [Display(Name = "Profile Image")]
        public IPublishedContent Avatar { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> GenderList { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }
    }

    public class EmployerProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company name cannot be blank")]
        public string CompanyName { get; set; }

        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Phone number cannot be blank")]
        public string Phone { get; set; }

        [Display(Name = "Fax number")]
        public string Fax { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State or Region")]
        public string State { get; set; }

        [Display(Name = "Postcode")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        [Display(Name = "Profile Image")]
        public IPublishedContent LogoImage { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }

    }

    public class SchoolProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "School Name")]
        [Required(ErrorMessage = "School name cannot be blank")]
        public string SchoolName { get; set; }

        [Display(Name = "Director Name")]
        public string DirectorName { get; set; }

        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Phone number cannot be blank")]
        public string Phone { get; set; }

        [Display(Name = "Fax number")]
        public string Fax { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State or Region")]
        public string State { get; set; }

        [Display(Name = "Postcode")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Profile Image")]
        public IPublishedContent Picture { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> CountryList { get; set; }

    }

    public class OrganizationProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Organization Name")]
        [Required(ErrorMessage = "Organization name cannot be blank")]
        public string OrganizationName { get; set; }

        [Display(Name = "Director Name")]
        public string DirectorName { get; set; }

        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Phone number cannot be blank")]
        public string Phone { get; set; }

        [Display(Name = "Fax number")]
        public string Fax { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State or Region")]
        public string State { get; set; }

        [Display(Name = "Postcode")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        [Display(Name = "Profile Image")]
        public IPublishedContent Picture { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }

    }

    public class TeacherProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        public string Gender { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State or Region")]
        public string State { get; set; }

        [Display(Name = "Postcode")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "School")]
        public string School { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        [Display(Name = "Teaching Years")]
        [Required(ErrorMessage = "Teaching years cannot be blank")]
        public string TeachingYears { get; set; }

        [Display(Name = "Profile Image")]
        public IPublishedContent Picture { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> GenderList { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }

    }

    public class AmbassadorProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        public string Gender { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Fax number")]
        public string Fax { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State or Region")]
        public string State { get; set; }

        [Display(Name = "Postcode")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Employer")]
        public string Employer { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        [Display(Name = "Working Years")]
        [Required(ErrorMessage = "Teaching years cannot be blank")]
        public string WorkingYears { get; set; }

        [Display(Name = "Profile Image")]
        public IPublishedContent Picture { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> GenderList { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }

    }

    public class LiaisonProfileModel
    {
        public int MemberId { get; set; }

        [Display(Name = "Firstname Lastname")]
        [Required(ErrorMessage = "Full name cannot be blank")]
        public string FullName { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        public string Gender { get; set; }

        [Display(Name = "Phone number")]
        public string Phone { get; set; }

        [Display(Name = "Fax number")]
        public string Fax { get; set; }

        [Display(Name = "Address (street, number)")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State or Region")]
        public string State { get; set; }

        [Display(Name = "Postcode")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }

        [Display(Name = "Employer")]
        public string Employer { get; set; }

        [Display(Name = "Job Sector")]
        [Required(ErrorMessage = "Job Sector cannot be blank")]
        public string JobSector { get; set; }

        [Display(Name = "Working Years")]
        [Required(ErrorMessage = "Teaching years cannot be blank")]
        public string WorkingYears { get; set; }

        [Display(Name = "Profile Image")]
        public IPublishedContent Picture { get; set; }

        public string UrlSlug { get; set; }

        public IEnumerable<SelectListItem> GenderList { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> JobSectorList { get; set; }

    }

}