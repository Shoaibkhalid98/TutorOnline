using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutorOnline.DataBase;
using TutorOnline.web.TutorOnline.Entities;

namespace TutorOnline.web.TutorOnline.Services
{
    public class LoginServices
    {
        #region
        public static LoginServices Instance
        {
            get
            {
                if (instance == null) instance = new LoginServices();

                return instance;
            }
        }
        private static LoginServices instance { get; set; }
        private LoginServices()
        {

        }
        #endregion
        public void SaveStudent(Login std)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                context.login.Add(std);
                context.SaveChanges();
            }
        }
        public Login GetStudent(string email, string password)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            using (var context = new TOContext())
            {
                return context.login.Where(x => x.Email == email && x.Password == password).FirstOrDefault(); ;
            }
        }
    }
}