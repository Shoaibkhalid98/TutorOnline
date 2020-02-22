using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutorOnline.DataBase;
using TutorOnline.Entities;

namespace TutorOnline.web.TutorOnline.Services
{
    public class StudentServices
    {
        #region
        public static StudentServices Instance
        {
            get
            {
                if (instance == null) instance = new StudentServices();

                return instance;
            }
        }
        private static StudentServices instance { get; set; }
        private StudentServices()
        {

        }
        #endregion


        public void SaveStudent(Student std)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                context.student.Add(std);
                context.SaveChanges();
            }
        }
        public Student GetStudent(string email, string password)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                return context.student.Where(x => x.Email == email && x.Password == password).FirstOrDefault(); ;
            }
        }

        public Student GetStudent(int ID)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                return context.student.Find(ID);
            }
        }



        public List<Student> GetAllStudent()
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                var stds = context.student.ToList();
                return stds;
            }
        }




        public void DeleteStudent(int ID)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {

                var student = context.student.Find(ID);

                context.Entry(student).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void EditStudent(Student std)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                context.Entry(std).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}