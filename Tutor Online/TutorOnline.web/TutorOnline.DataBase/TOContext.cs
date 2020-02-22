using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorOnline.Entities;
using TutorOnline.web.TutorOnline.Entities;

namespace TutorOnline.DataBase
{
    public class TOContext : DbContext, IDisposable
    {
        public TOContext() : base("TutorOnline-Database")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> student { get; set; }
        public DbSet<Teacher> teacher { get; set; }

        public DbSet<Login> login { get; set; }
    }
}
