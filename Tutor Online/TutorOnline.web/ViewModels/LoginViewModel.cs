using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutorOnline.Entities;

namespace TutorOnline.web.ViewModels
{
    public class LoginViewModel
    {
        public Student student { get; set; }
        public Teacher teacher { get; set; }

        public String type { get; set; }
    }
}