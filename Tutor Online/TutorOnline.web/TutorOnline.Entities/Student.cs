using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorOnline.Entities
{
    public class Student : User
    {
        public List<Teacher> BookedTeacher { get; set; }

        public List<int> BookedTeachersIDs { get; set; }
    }
}
