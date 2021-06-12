using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseImage { get; set; }
        public string CourseLevel { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<User_Course> User_Course { get; set; }
        public List<Lecturer_Course> Lecturer_Course { get; set; }

    }
}
