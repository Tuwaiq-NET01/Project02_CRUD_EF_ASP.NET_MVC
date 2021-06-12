using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University_Project3_SSMS.Models
{
    public class InstructorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }

        // navication propetis : on-to-many: Instructor---<- Students
        public List<StudentModel> Student { get; set; }

        
    }
}
