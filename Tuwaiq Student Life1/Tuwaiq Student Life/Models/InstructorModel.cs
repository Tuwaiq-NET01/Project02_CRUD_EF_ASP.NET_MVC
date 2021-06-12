using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuwaiq_Student_Life.Models
{
    public class InstructorModel
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; } 
        public string Email { set; get; }
        public string Bio { set; get; }

        public ICollection<InstructorStudentModel> Students { set; get; }
        public ICollection<SessionModel> Sessions { set; get; }
        public SubjectModel Subject { set; get; }
        public int SubjectId { set; get; }
    }
}
