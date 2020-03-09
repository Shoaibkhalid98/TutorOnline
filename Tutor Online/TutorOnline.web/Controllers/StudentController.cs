using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorOnline.web.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Student()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }
        
        public ActionResult UpdateProfile()
        {
            return View();
        }
        
        public ActionResult SearchTeacher()
        {
            return View();
        }
        
        public ActionResult ShowListOfTeachers()
        {
            return View();
        }
        
        public ActionResult SendFeedback()
        {
            return View();
        }
        
        public ActionResult ViewFeedback()
        {
            return View();
        }
    }
}