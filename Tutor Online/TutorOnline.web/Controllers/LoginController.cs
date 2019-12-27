using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorOnline.web.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            if (Email.Equals("Admin@admin.com") && Password.Equals("464566007"))
            {
                return Redirect(@Url.Action("Dashboard","Admin"));
            }
            else if (Email.Equals("Student@student.com") && Password.Equals("464566007"))
            {
                return Redirect(@Url.Action("Dashboard", "Student"));
            }
            else if (Email.Equals("Teacher@teacher.com") && Password.Equals("464566007"))
            {
                return Redirect(@Url.Action("Dashboard", "Teacher"));
            }
            else
            {
                return HttpNotFound();
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}