using System;
using System.Collections.Generic;

namespace StudentApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }


        public List<Question> Questions { get; set; }

        public ICollection<StudentCourse> StudentCourse { get; set; }


    }
}
