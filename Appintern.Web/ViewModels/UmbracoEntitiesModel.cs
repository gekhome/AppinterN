using Appintern.Web.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;

namespace Appintern.Web.ViewModels
{
    public class UmbracoArticleModel
    {
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "You must give a name to the article")]
        [Display(Name = "Article Name")]
        public string ArticleName { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Article Date")]
        public DateTime ArticleDate { get; set; }

        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }

        [Display(Name = "Article Title")]
        public string Title { get; set; }

        [Display(Name = "Article Description")]
        public HtmlString Description { get; set; }

        [Display(Name = "Article Member")]
        public int MemberId { get; set; }

        [Display(Name = "Categories")]
        public string[] SelectedCategories { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Meta Name")]
        public string MetaName { get; set; }

        [Display(Name = "Meta Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "Meta Keywords (comma separated keywords)")]
        public string MetaKeywords { get; set; }

        public List<string> Categories { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }
    }

    public class ArticleImageModel
    {
        [Required(ErrorMessage = "You must select an image file before submitting the form")]
        [Display(Name = "Main Image")]
        [MaxFileSize(300 * 1024, ErrorMessage = "Maximum allowed file size is {0} bytes")]
        public HttpPostedFileBase MainImage { get; set; }

        public int ArticleId { get; set; }

        public string ImageUrl { get; set; }

        public string ImageUdi { get; set; }
    }

    public class UmbracoApprenticeshipModel
    {
        public int ApprenticeshipId { get; set; }

        [Required(ErrorMessage = "You must give a name to the apprenticeship")]
        [Display(Name = "Apprenticeship Name")]
        public string ApprenticeshipName { get; set; }

        [Display(Name = "Apprenticeship Title")]
        public string Title { get; set; }

        [Display(Name = "Apprenticeship Member")]
        public int MemberId { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Post Date")]
        public DateTime PostDate { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Duration")]
        public string Duration { get; set; }

        [Display(Name = "Commitment")]
        public string Commitment { get; set; }

        [Display(Name = "Compensation")]
        public string Compensation { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Categories")]
        public string[] SelectedCategories { get; set; }

        [Display(Name = "Job Sectors")]
        public string JobSector { get; set; }

        [Display(Name = "Apprenticeship Description")]
        public HtmlString Description { get; set; }

        [Display(Name = "Responsibilities")]
        public HtmlString Responsibilities { get; set; }

        [Display(Name = "Benefits")]
        public HtmlString Benefits { get; set; }

        [Display(Name = "Qualifications")]
        public HtmlString Qualifications { get; set; }

        [Display(Name = "Meta Name")]
        public string MetaName { get; set; }

        [Display(Name = "Meta Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "Meta Keywords (comma separated keywords)")]
        public string MetaKeywords { get; set; }

        public List<string> Categories { get; set; }

        public IEnumerable<SelectListItem> JobSectors { get; set; }

        public IEnumerable<SelectListItem> Durations { get; set; }

        public IEnumerable<SelectListItem> Commitments { get; set; }

        public IEnumerable<SelectListItem> Compensations { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        public IEnumerable<SelectListItem> Statuses { get; set; }
    }

    public class ApprenticeshipImageModel
    {
        [Required(ErrorMessage = "You must select an image file before submitting the form")]
        [Display(Name = "Main Image")]
        [MaxFileSize(300 * 1024, ErrorMessage = "Maximum allowed file size is {0} bytes")]
        public HttpPostedFileBase MainImage { get; set; }

        public int ApprenticeshipId { get; set; }

        public string ImageUrl { get; set; }

        public string ImageUdi { get; set; }
    }

    public class MemberImageModel
    {
        [Required(ErrorMessage = "You must select an image file before submitting the form")]
        [Display(Name = "Main Image")]
        [MaxFileSize(200 * 1024, ErrorMessage = "Maximum allowed file size is {0} bytes")]
        public HttpPostedFileBase Avatar { get; set; }

        public int MemberId { get; set; }
        public string ImageUrl { get; set; }

        public string ImageUdi { get; set; }
    }

    public class MemberDocumentModel
    {
        [Required(ErrorMessage = "You must select a document file before submitting the form")]
        [Display(Name = "Main Image")]
        [MaxFileSize(500 * 1024, ErrorMessage = "Maximum allowed file size is {0} bytes")]
        public HttpPostedFileBase Attachment { get; set; }

        public int MemberId { get; set; }
        public string FileUrl { get; set; }

        public string FileName { get; set; }
    }

}
