using System;
using System.Collections.Generic;

namespace StudentApp.Models
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string img { get; set; }

        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
