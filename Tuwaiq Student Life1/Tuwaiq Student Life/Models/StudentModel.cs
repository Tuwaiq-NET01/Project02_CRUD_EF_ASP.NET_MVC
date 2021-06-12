using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuwaiq_Student_Life.Models
{
    public class StudentModel
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }

        public ICollection<InstructorStudentModel> Instructors { set; get; }
        public ICollection<StudentSessionModel> Sessions { set; get; }
    }
}
