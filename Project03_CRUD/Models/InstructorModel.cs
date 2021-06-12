using System;
using System.Collections.Generic;

namespace Project03_CRUD.Models
{
    public class InstructorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public List<CourseModel> Courses { get; set; }
    }
}
