using Microsoft.AspNetCore.Mvc;
using Mvc_Project2.Data;
using Mvc_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Project2.Controllers
{
    public class PassenegrsController : Controller
    {
        private readonly AppDbContext _db;

        public PassenegrsController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
          var passenegrs = _db.passengers.ToList();
            ViewData["Passenegrs"] = passenegrs;
            return View();
        }

        public IActionResult Details(int? id)
        {
            var passenegrs = _db.passengers.ToList().Find(passenegrs => passenegrs.Id == id);
            ViewData["Passenegrs"] = passenegrs;
            return View(passenegrs);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("ID", "Name", "Email", "PhoneNum", "PlaneId")] PassengerModel passengers)
        {
            _db.passengers.Add(passengers);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var passengers = _db.passengers.ToList().Find(p => p.Id == id);
            if (id == null || passengers == null)
            {
                return View("_NotFound");
            }
            return View(passengers);
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id", "Name", "Email", "PhoneNum", "PlaneId")] PassengerModel passengers)
        {
            _db.passengers.Update(passengers);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var passengers = _db.passengers.ToList().Find(p => p.Id == id);
            _db.passengers.Remove(passengers);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
