using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project03_CRUD.Data;
using Project03_CRUD.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project03_CRUD.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly AppDbContext _db;

        public InstructorsController(AppDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var instructors = _db.Instructors.ToList();
            ViewBag.instructors = instructors;
            return View();
        }

        // GET: /<controller>/id
        public IActionResult Details(int? id)
        {
            var instructor = _db.Instructors.ToList().Find(i => i.Id == id);
            if (id == null || instructor == null)
            {
                return View("_NotFound");
            }
            ViewBag.instructor = instructor;
            return View();

        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id", "Name", "DOB")] InstructorModel inst)
        {
            if (ModelState.IsValid)
            {
                _db.Instructors.Add(inst);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Edit(int? id)
        {
            var product = _db.Instructors.ToList().Find(p => p.Id == id);

            if (id == null || product == null)
            {
                return View("_NotFound");
            }
            return View(product);
        }


        [HttpPost]
        public IActionResult Edit([Bind("Id", "Name", "DOB")] InstructorModel item)
        {
            _db.Instructors.Update(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var ins = _db.Instructors.ToList().Find(p => p.Id == id);
            if (id == null || ins == null)
            {
                return View("_NotFound");
            }
            _db.Instructors.Remove(ins);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
