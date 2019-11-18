using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="username is required")]
        [MinLength(5, ErrorMessage ="username should be atleast 5 letters")]
        [Display(Name = "Username : ")]
        public string UserName { get; set; }



        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.Password)]
        [Display(Name ="Password : ")]
        public string Password { get; set; }



        [Display(Name = "Keep me signed in : ")]
        public bool RememberMe { get; set; }
    }
}