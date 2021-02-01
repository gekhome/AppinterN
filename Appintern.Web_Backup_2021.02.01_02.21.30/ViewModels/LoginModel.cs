using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Appintern.Web.ViewModels
{
    public class LoginModel
    {

        [Display(Name = "Username")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }

    public class SignUpModel
    {
        [StringLength(255, ErrorMessage = "Must be at most 255 characters.")]
        [Display(Name = "Full Name or Institution name or Tradename")]
        [Required]
        public string Name { get; set; }

        [StringLength(20, ErrorMessage = "Must be at most 20 characters.")]
        [RegularExpression(@"^[.A-Za-z0-9_-]+$", ErrorMessage = "Only latin characters, numbers, dots, hyphens, no spaces")]
        [Display(Name = "Username")]
        [Required]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }


        [StringLength(20, ErrorMessage = "Must be at most 20 characters.")]
        [RegularExpression(@"^[\S]+$", ErrorMessage = "Space character not allowed")]
        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(20, ErrorMessage = "Must be at most 20 characters.")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The confirmation password does not match the password.")]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Member type")]
        [Required(ErrorMessage ="Member type cannot be blank.")]
        public string MemberCategory { get; set; }

        public IEnumerable<SelectListItem> MemberCategories { get; set; }

    }
}