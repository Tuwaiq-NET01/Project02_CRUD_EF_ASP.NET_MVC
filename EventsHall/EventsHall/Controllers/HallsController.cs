using EventsHall.Data;
using EventsHall.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsHall.Controllers
{
    public class HallsController : Controller
    {
        private readonly AppDbContext _db;

        public HallsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbHalls = _db.Halls.ToList();
            ViewBag.Halls = DbHalls;
            return View();
        }

        public IActionResult Create()
        {

            return View("Create");
        }

        [HttpPost]
        public IActionResult Create([Bind("Name", "Capacity", "Avaliability")] HallModel hall)
        {
            if (ModelState.IsValid)
            {
                _db.Halls.Add(hall);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }

        public IActionResult Edit(int? id)
        {
            var Hall = _db.Halls.ToList().Find(p => p.Id == id);
            if (id == null || Hall == null)
            {
                return View("_NotFound");
            }
            ViewData["Hall"] = Hall;
            return View();
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id", "Name", "Avaliability","Capacity")] HallModel hall)
        {
            _db.Halls.Update(hall);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var hall = _db.Halls.ToList().FirstOrDefault(p => p.Id == id);
            if (id == null || hall == null)
            {
                return View("_NotFound");
            }
            _db.Halls.Remove(hall);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

   