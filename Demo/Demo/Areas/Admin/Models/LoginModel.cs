using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Please enter username")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Please enter username")]
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}