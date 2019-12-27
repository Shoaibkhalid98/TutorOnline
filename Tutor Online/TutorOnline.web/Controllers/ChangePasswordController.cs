using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorOnline.web.Controllers
{
    public class ChangePasswordController : Controller
    {
        // GET: ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        public ActionResult ChangePasswordPage()
        {
            return View();
        }
        
        public ActionResult TeacherChangePasswordPage()
        {
            return View();
        }
        public ActionResult AdminChangePasswordPage()
        {
            return View();
        }
    }
}