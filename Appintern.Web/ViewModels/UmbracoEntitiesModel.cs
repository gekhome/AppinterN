using Appintern.Web.Library;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
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
        public DateTime? ArticleDate { get; set; }

        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }

        [Display(Name = "Article Title")]
        public string Title { get; set; }

        [Display(Name = "Article Description")]
        public IHtmlString Description { get; set; }

        [Display(Name = "Main Image")]
        //[MaxFileSize(100 * 1024, ErrorMessage = "Maximum allowed file size is {0} bytes")]
        public HttpPostedFileBase MainImage { get; set; }

        [Display(Name = "Article Member")]
        public int MemberId { get; set; }

        [Display(Name = "Categories")]
        public string Categories { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Meta Name")]
        public string MetaName { get; set; }

        [Display(Name = "Meta Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "Meta Keywords")]
        public string MetaKeywords { get; set; }
    }
}
