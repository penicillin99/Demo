using Demo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Demo.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index(LoginModel model)
        {
            if(Membership.ValidateUser(model.UserName,model.Password) && ModelState.IsValid)
            {
                FormsAuthentication.GetAuthCookie(model.UserName, model.RememberMe);
                return RedirectToAction("Index", "User");
            }
            else
            {
                ModelState.AddModelError("", "Login false");
            }
            return View(model);
        }
    }
}