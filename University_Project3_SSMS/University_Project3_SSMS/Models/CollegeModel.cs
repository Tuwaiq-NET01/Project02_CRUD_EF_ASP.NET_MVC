using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University_Project3_SSMS.Models
{
    public class CollegeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // navication propetis : on-to-many: College---<- Students
        public List<StudentModel> Student { get; set; }

       
    }
}
