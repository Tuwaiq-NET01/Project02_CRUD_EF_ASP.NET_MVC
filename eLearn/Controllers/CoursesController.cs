using eLearn.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _db;
        public CoursesController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Courses = _db.Course.ToList();
            ViewData["Courses"] = Courses;
            return View();
        }
        public IActionResult Details(int? id = 1)
        {
            var Course = _db.Course.ToList().Find(a => a.Id == id);
            ViewData["Details"] = Course;

            if (Course == null)
            {
                return Content("Not found");
            }
            else
            {
                ViewData["Course"] = Course;
                return View();
            }
        }
    }
}
