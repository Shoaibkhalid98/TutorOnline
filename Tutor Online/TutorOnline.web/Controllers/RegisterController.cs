using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorOnline.web.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegisterStudent()
        {
            return View();
        }
        public ActionResult RegisterTeacher()
        {
            return View();
        }
    }
}