using Appintern.Web.Library;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Appintern.Web.ViewModels
{
    public class EditAvatarModel
    {
        [Display(Name = "Avatar")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Only Image files are allowed.")]
        [MaxFileSize(100 * 1024, ErrorMessage = "Maximum allowed file size is {0} bytes")]
        public HttpPostedFileBase Avatar { get; set; }
    }

}