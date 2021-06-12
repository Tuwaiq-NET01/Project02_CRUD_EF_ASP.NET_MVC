using System;
namespace Project03_CRUD.Models
{
    public class CourseModel
    {
        public CourseModel()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime PublishDate { get; set; }
        public float duration { get; set; } // in hrs

        public InstructorModel Instructor { get; set; }
        public int Instructor_Id { get; set; }
    }
    //public string Instructor { get; set; }
}
