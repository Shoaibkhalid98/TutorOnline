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
        public ActionResult Login(Login user)
        {
            LoginViewModel model = new LoginViewModel();
            if (user.Email.Equals("Admin@admin.com") && user.Password.Equals("464566007"))
            {
                model.type = "Admin";
                return RedirectToAction("Dashboard","Admin");
            }
            var student = StudentServices.Instance.GetStudent(user.Email, user.Password);
            
            if (student!= null && user.Email.Equals(student.Email) && user.Password.Equals(student.Password))
            {
                model.type = "Student";
                model.student = student;
                return RedirectToAction(@Url.Action("Dashboard", "Student"));
            }
            var teacher = TeacherServices.Instance.GetTeacher(user.Email, user.Password);

            if (teacher != null && user.Email.Equals(teacher.Email) && user.Password.Equals(teacher.Password))
            {
                model.type = "Teacher";
                model.teacher = teacher;
                return RedirectToAction(@Url.Action("Dashboard", "Teacher"));
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