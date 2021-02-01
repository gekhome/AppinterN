using Appintern.Web.Library;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Appintern.Web.ViewModels
{
    public class EditAvatarModel
    {
        [Required(ErrorMessage ="You must select a file before submitting the form")]
        [Display(Name = "Avatar")]
        [MaxFileSize(100 * 1024, ErrorMessage = "Maximum allowed file size is {0} bytes")]
        public HttpPostedFileBase Avatar { get; set; }
    }

}