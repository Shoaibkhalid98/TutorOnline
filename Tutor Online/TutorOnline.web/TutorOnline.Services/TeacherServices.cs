using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutorOnline.DataBase;
using TutorOnline.Entities;

namespace TutorOnline.web.TutorOnline.Services
{
    public class TeacherServices
    {
        #region
        public static TeacherServices Instance
        {
            get
            {
                if (instance == null) instance = new TeacherServices();

                return instance;
            }
        }
        private static TeacherServices instance { get; set; }
        private TeacherServices()
        {

        }
        #endregion


        public void SaveUser(Teacher teach)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                context.teacher.Add(teach);
                context.SaveChanges();
            }
        }
        public Teacher GetTeacher(string email, string password)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                return context.teacher.Where(x => x.Email == email && x.Password == password).FirstOrDefault(); ;
            }
        }

        public Teacher GetTeacher(int ID)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                return context.teacher.Find(ID);
            }
        }



        public List<Teacher> GetAllTeachers()
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                var teachers = context.teacher.ToList();
                return teachers;
            }
        }




        public void DeleteTeacher(int ID)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {

                var teacher = context.teacher.Find(ID);

                context.Entry(teacher).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void EditTeacher(Teacher te)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                context.Entry(te).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}