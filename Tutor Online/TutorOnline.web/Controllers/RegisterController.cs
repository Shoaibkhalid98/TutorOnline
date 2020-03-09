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
    public class RegisterController : Controller
    {
        // GET: Register
        [HttpPost]
        public ActionResult RegisterStudent(RegisterStudentViewModel model)
        {
            //extract data from model to login table
            var login = new Login();
            login.Adress = model.Adress;
            login.Description = model.Description;
            login.Email = model.Email;
            login.imageUrl = model.imageUrl;
            login.Name = model.Name;
            login.Password = model.Password;
            login.phone = model.phone;
            login.userType = model.userType;
            //extract data from model to Student table
            var student = new Student();
            student.Adress = login.Adress;
            student.Description = login.Description;
            student.Email = login.Email;
            student.imageUrl = login.imageUrl;
            student.Name = login.Name;
            student.Password = login.Password;
            student.phone = login.phone;
            LoginServices.Instance.SaveLogin(login);
            StudentServices.Instance.SaveStudent(student);
            return View();
        }

        [HttpGet]
        public ActionResult RegisterStudent()
        {
            return View(new RegisterStudentViewModel());
        }
        [HttpPost]
        public ActionResult RegisterTeacher(RegisterTeacherViewModel model)
        {

            //extract data from model to login table
            var login = new Login();
            login.Adress = model.Adress;
            login.Description = model.Description;
            login.Email = model.Email;
            login.imageUrl = model.imageUrl;
            login.Name = model.Name;
            login.Password = model.Password;
            login.phone = model.phone;
            login.userType = model.userType;

            //extract data from model to login table
            var teacher = new Teacher();
            teacher.Adress = model.Adress;
            teacher.Description = model.Description;
            teacher.Email = model.Email;
            teacher.imageUrl = model.imageUrl;
            teacher.Name = model.Name;
            teacher.Password = model.Password;
            teacher.phone = model.phone;
            teacher.DegreeImageUrl = model.DegreeImageUrl;
            teacher.currentAccountStatus = "UnVerified";

            LoginServices.Instance.SaveLogin(login);
            TeacherServices.Instance.SaveTeacher(teacher);
            return View();
        }
        [HttpGet]
        public ActionResult RegisterTeacher()
        {
            return View(new RegisterTeacherViewModel());
        }
    }
}