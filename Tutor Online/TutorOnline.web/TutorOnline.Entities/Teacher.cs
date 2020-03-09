using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorOnline.Entities
{
    public class Teacher : User
    {
        public decimal salary { get; set; }

        public List<Student> RegisteredStudents { get; set; }

        public List<int> RegisteredStudentsIDs { get; set; }
        [Required]
        public String DegreeImageUrl { get; set; }

        public String currentAccountStatus { get; set; }
    }
}
