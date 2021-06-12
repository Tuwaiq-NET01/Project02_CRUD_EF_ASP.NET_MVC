using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuwaiq_Student_Life.Models
{
    public class InstructorStudentModel
    {
        public int Id { set; get; }
        public int StudentId { set; get; }
        public StudentModel Studen { set; get; }
        public int InstructorId { set; get; }
        public InstructorModel Instructor {set; get;}

    }
}
