using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University_Project3_SSMS.Models
{
    public class StudentModel
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Major { get; set; }

        // navication propetis : on-to-many: College---<- Students
        public int CollegeId { get; set; }
        public CollegeModel College { get; set; }

        // navication propetis : on-to-many: Instructor---<- Students
        public int InstructorId { get; set; }
        public InstructorModel Instructor { get; set; }

    }
}
