using CrudHomework.Data;
using CrudHomework.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHomework.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext db;

        public StudentsController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            ViewData["Records"] = this.db.Students.ToList();
            return View();
        }

        public IActionResult GetById(int id)
        {
            ViewData["Row"] = this.db.Students.Where(e => e.Id == id).FirstOrDefault();
            if (ViewData["Row"] == null) return NotFound();

            return View();
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = this.db.Students.Where(e => e.Id == id).FirstOrDefault();
            if (model == null) return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Student s)
        {
            var model = this.db.Students.Where(e => e.Id == s.Id).FirstOrDefault();
            if (model == null) return NotFound();

            model.Name = s.Name;
            this.db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            var model = this.db.Students.Where(e => e.Id == s.Id).FirstOrDefault();
            if (model != null) return BadRequest();

            this.db.Students.Add(s);
            this.db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var model = this.db.Students.Where(e => e.Id == id).FirstOrDefault();
            if (model == null) return BadRequest();

            this.db.Students.Remove(model);
            this.db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
