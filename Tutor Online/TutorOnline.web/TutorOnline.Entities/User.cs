using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TutorOnline.Entities
{
    public class User
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
        public List<String> subjectNames { get; set; }
    }
}
