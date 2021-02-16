using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Appintern.Web.ViewModels
{
    public class GenderViewModel
    {
        public int GenderID { get; set; }

        [StringLength(20, ErrorMessage = "Must be at most 20 characters.")]
        [Display(Name = "Gender")]
        public string GenderText { get; set; }
    }

    public class MemberGroupViewModel
    {
        public int MemberGroupID { get; set; }

        [StringLength(50, ErrorMessage = "Must be at most 50 characters.")]
        [Required(ErrorMessage = "Member type cannot be blank")]
        [Display(Name = "Gender")]
        public string MemberGroupText { get; set; }
    }

    public class CountriesViewModel
    {
        public string Country { get; set; }
    }
}
