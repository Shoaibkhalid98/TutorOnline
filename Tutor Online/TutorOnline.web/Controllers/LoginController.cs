using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutorOnline.Entities;
using TutorOnline.web.TutorOnline.Entities;
using TutorOnline.web.TutorOnline.Services;
using TutorOnline.web.ViewModels;

namespace TutorOnline.web.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            var login = LoginServices.Instance.GetLogin(model.Email, model.Password);
            if (login.userType.Equals("Admin"))
            {
                model.UserType = "Admin";
                return RedirectToAction("Dashboard", "Admin");
            }
            else if (login.userType.Equals("Student"))
            {
                model.UserType = "Student";
                return RedirectToAction("Dashboard", "Student");
            }
            else if (login.userType.Equals("Teacher"))
            {
                model.UserType = "Teacher";
                return RedirectToAction("Dashboard", "Teacher");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }
    }
}