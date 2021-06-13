using System;
namespace StudentApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string question { get; set; }
        public String Answer { get; set; }
        public int Difficulty { get; set; }


        public int CourseId { get; set; }
        public Course Course { get; set; }



    }
}
