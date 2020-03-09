using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutorOnline.Entities;

namespace TutorOnline.web.ViewModels
{
    public class LoginViewModel
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public String UserType { get; set; }
    }
}