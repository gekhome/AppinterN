﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Appintern.Web.ViewModels
{
    /// <summary>
    /// CURRENTLY NOT USED! - JUST FOR TESTING TELERIK
    /// </summary>
    public class AmbassadorsViewModel
    {
        public int MemberID { get; set; }
        public string TaxNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string SocialMedia { get; set; }
        public string Occupation { get; set; }
        public string JobSector { get; set; }
        public string Employer { get; set; }
        public string LoginName { get; set; }

        public AmbassadorsViewModel()
        { }
    }

    public class EmployersViewModel
    {
        public int MemberID { get; set; }
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Headquarters { get; set; }
        public string Country { get; set; }
        public string JobSector1 { get; set; }
        public string JobSector2 { get; set; }
        public string JobSector3 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string SocialMedia { get; set; }
        public string LoginName { get; set; }
        public string JobSectors { get; set; }

        public EmployersViewModel()
        { }
    }

    public class GraduatesViewModel
    {
        public int MemberID { get; set; }
        public string TaxNumber { get; set; }
        public string FullName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Specialization { get; set; }
        public string School { get; set; }
        public string LoginName { get; set; }
    }

    public class LiaisonOfficersViewModel
    {
        public int MemberID { get; set; }
        public string TaxNumber { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OfficeAddress { get; set; }
        public string Occupation { get; set; }
        public string Employer { get; set; }
        public string LoginName { get; set; }
    }

    public class OrganizationsViewModel
    {
        public int MemberID { get; set; }
        public string TaxNumber { get; set; }
        public string OrganizationName { get; set; }
        public string ContactPerson { get; set; }
        public string Country { get; set; }
        public string Headquarters { get; set; }
        public string JobSector { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string SocialMedia { get; set; }
        public string LoginName { get; set; }
    }

    public class SchoolsViewModel
    {
        public int MemberID { get; set; }
        public string TaxNumber { get; set; }
        public string SchoolName { get; set; }
        public string ContactPerson { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string SocialMedia { get; set; }
        public string LoginName { get; set; }
    }

    public class StudentsViewModel
    {
        public int MemberID { get; set; }
        public string TaxNumber { get; set; }
        public string FullName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Specialization { get; set; }
        public string School { get; set; }
        public string LoginName { get; set; }
    }

    public class TeachersViewModel
    {
        public int MemberID { get; set; }
        public string TaxNumber { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string School { get; set; }
        public string SchoolAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SocialMedia { get; set; }
        public string LoginName { get; set; }
    }

    public class ApprenticeshipViewModel
    {
        public int ApprenticeshipID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        public string DurationMonths { get; set; }
        public string Commitment { get; set; }
        public string Compensation { get; set; }
        public string JobSector { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Post Date")]
        public DateTime? PostDate { get; set; }
        public int EmployerID { get; set; }

        public ApprenticeshipViewModel()
        { }

        public ApprenticeshipViewModel(int apprId, string name, string title, DateTime? postDate, string duration, string commitment, string compensation,
                                       string jobSector, string country, int employerId, string description, string status, DateTime? startDate, DateTime? endDate)
        {
            ApprenticeshipID = apprId;
            Name = name;
            Title = title;
            PostDate = postDate;
            DurationMonths = duration;
            Commitment = commitment;
            Compensation = compensation;
            Country = country;
            JobSector = jobSector;
            EmployerID = employerId;
            Description = description;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
        }
    }

    public class ArticleViewModel
    {
        public int ArticleId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Article Date")]
        public DateTime? ArticleDate { get; set; }

        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public int ArticleMemberId { get; set; }

        public ArticleViewModel()
        { }

        public ArticleViewModel(int articleId, DateTime? articleDate, string authorName, string name, string title, string description, string country, int articleMemberId = 0)
        {
            ArticleId = articleId;
            ArticleDate = articleDate;
            AuthorName = authorName;
            Name = name;
            Title = title;
            Description = description;
            Country = country;
            ArticleMemberId = articleMemberId;
        }
    }

    public class LoggedMemberModel
    {
        public int MemberId { get; set; }

        public string MemberName { get; set; }

        public string MemberType { get; set; }
    }
}
