using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University_Project3_SSMS.Data;
using University_Project3_SSMS.Models;

namespace University_Project3_SSMS.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _db;

        public StudentsController(AppDbContext db)
        {
            _db = db;
        }
        // GET: /Students
        public IActionResult Index()
        {
            var Students = _db.Students.ToList();
            ViewData["Students"] = Students;
            return View();
        }

        // GET: /Students/id
        public IActionResult Details(int? id)
        {
            var Students = _db.Students.ToList().Find(product => product.Id == id);
            if (id == null || Students == null)
            {
                return View("_NotFound");
            }
            ViewData["Students"] = Students;
            return View(Students);

        }

        // Create

        // GET: /Students/create
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        // Post: /Students/create
        [HttpPost]
        public IActionResult Create([Bind( "Name", "PhoneNum", "DateOfBirth", "Major", "CollegeId", "InstructorId")] StudentModel Students)
        {
            // if for validations
            if (ModelState.IsValid)
            {
                _db.Students.Add(Students);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Students);
        }

        // Updte

        // GET: /Students/edit/id
        public IActionResult Edit(int? id)
        {
            var Students = _db.Students.ToList().Find(p => p.Id == id);
            if (id == null || Students == null)
            {
                return View("_NotFound");
            }
            ViewData["Students"] = Students;
            return View();
        }

        // POST: /Students/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id", "Name", "PhoneNum", "DateOfBirth", "Major", "CollegeId", "InstructorId")] StudentModel Students)
        {
            _db.Students.Update(Students);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: /Students/delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Product = _db.Students.ToList().Find(p => p.Id == id);
            if (id == null || Product == null)
            {
                return View("_NotFound");
            }
            _db.Students.Remove(Product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
