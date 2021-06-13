using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApp.Data;
using StudentApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentApp.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _Db;

        public StudentController(AppDbContext appDb)
        {
            this._Db = appDb;
        }


        // Display All Students in the database
        [HttpGet]
        public List<Student>  Get()
        {
            var students = _Db.Students.ToList();
            
            return students;
        }


        // Display All courses related Student in the database
        [Route("{id:int}")]
        [HttpGet]
        public async Task<List<Course>> Get(int id)
        {
            var courses = _Db.Courses.FromSqlRaw("select * from Courses where Id in (select CourseId from StudentCourse where StudentCourse.StudentId="+ id + ") ;").ToList();//.Where(c => c.Id== c.StudentCourse.Where(sc => sc.StudentId==id).)
            return courses;

        }

        // Delete student from the batabase
        [Route("{id:int}")]
        [HttpDelete]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var student = await _Db.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            _Db.Students.Remove(student);
            await _Db.SaveChangesAsync();

            return student;
        }

        // Add new student to the database with default course
        [HttpPost]
        public String Post( String name ,String Img)
        {

            Student s = new Student()
            {
                Name = name,
                img = Img,

            };
            _Db.Students.Add(s);
            _Db.SaveChanges();

            _Db.StudentCourse.Add(new StudentCourse()
            {
                CourseId = 1,
                StudentId=s.Id
            }
            ) ;
            _Db.SaveChanges();


            return name + " has been added to the database";//student;

        }

        // Edit Student in the database
        [HttpPatch]
        public String Eidt(int id, String name, String Img)
        {
            var s = _Db.Students.ToList().Find(s => s.Id == id);
            if (s !=null)
            {
                s.Name = name;
                s.img = Img;
                _Db.Students.Update(s);
                _Db.SaveChanges();


                return name + " has been edit ";//student;
            }





            return "Student with id "+id+" Not Found";

        }
    }
}
