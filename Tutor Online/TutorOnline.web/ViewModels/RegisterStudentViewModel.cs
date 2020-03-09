using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TutorOnline.web.ViewModels
{
    public class RegisterStudentViewModel
    {
        public int ID { get; set; }
        [Required]
        [MinLength(5), MaxLength(50)]
        public String Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public String Adress { get; set; }
        [Required]
        public String phone { get; set; }
        [Required]
        [MaxLength(50)]
        public String Description { get; set; }
        public String imageUrl { get; set; }
        public String userType { get; set; }

    }
}