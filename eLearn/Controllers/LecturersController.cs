using eLearn.Data;
using eLearn.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Controllers
{
    public class LecturersController : Controller
    {
        private readonly AppDbContext _db;
        public LecturersController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Lecturers = _db.Lecturer.ToList();
            ViewData["Lecturers"] = Lecturers;
            return View();
        }
        public IActionResult Details(int? id = 1)
        {
            var Lecturer = _db.Lecturer.ToList().Find(a => a.Id == id);
            ViewData["Details"] = Lecturer;

            if (Lecturer == null)
            {
                return Content("Not found");
            }
            else
            {
                ViewData["Course"] = Lecturer;
                return View();
            }
        }

        //GET - /products/create
        public IActionResult Create()
        {
            return View();
        }

        //POST - /proudcts/create
        [HttpPost]
        public IActionResult Create([Bind("Id", "FirstName", "LastName", "Email")] Lecturer Lecturer)
        {
            if (ModelState.IsValid) //check the state of model
            {
                _db.Lecturer.Add(Lecturer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Lecturer);
        }
        //GEt - /products/edit/id
        public IActionResult Edit(int? id)
        {
            var Lecturer = _db.Lecturer.ToList().Find(p => p.Id == id);
            if (id == null || Lecturer == null)
            {
                return View("_NotFound");
            }
            ViewData["Lecturer"] = Lecturer;
            return View();
        }

        //POST - /products/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id", "FirstName", "LastName", "Email")] Lecturer Lect)
        {

            _db.Lecturer.Update(Lect);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        // POST - /products/delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Lecturer = _db.Lecturer.ToList().FirstOrDefault(p => p.Id == id);
            if (id == null || Lecturer == null)
            {
                return View("_NotFound");
            }
            _db.Lecturer.Remove(Lecturer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
