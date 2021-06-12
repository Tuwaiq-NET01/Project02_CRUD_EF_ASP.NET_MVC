using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuwaiq_Student_Life.Models
{
    public class SubjectModel
    {
        public int Id { set; get; }
        public string SubjectName { set; get; }

        public ICollection<InstructorModel> Instructors { set; get; }
    }
}
