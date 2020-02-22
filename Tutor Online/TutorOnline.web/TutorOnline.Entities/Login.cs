using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorOnline.web.TutorOnline.Entities
{
    public class Login
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public string Email { get; set; }
        public String Password { get; set; }
        public String Adress { get; set; }
        public String phone { get; set; }
        public String Description { get; set; }
        public String imageUrl { get; set; }
        public String userType { get; set; }
    }
}