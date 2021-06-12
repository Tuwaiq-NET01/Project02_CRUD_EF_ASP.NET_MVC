using Microsoft.AspNetCore.Mvc;
using Mvc_Project2.Data;
using Mvc_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Project2.Controllers
{
    public class PlanesController : Controller
    {
        private readonly AppDbContext _db;

        public PlanesController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var planes = _db.Planes.ToList();
            ViewData["Planes"] = planes;

            return View();
        }

        // GET: /products/id
        public IActionResult Details(int? id)
        {
            var planes = _db.Planes.ToList().Find(planes => planes.Id == id);
            ViewData["Planes"] = planes;
            return View(planes);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("Id", "Name", "Airlines")] PlaneModel planes)
        {
            _db.Planes.Add(planes); ;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var planes = _db.Planes.ToList().Find(p => p.Id == id);
            if (id == null || planes == null)
            {
                return View("_NotFound");
            }
            return View(planes);
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id", "Name", "Airlines")] PlaneModel planes)
        {
            _db.Planes.Update(planes);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var planes = _db.Planes.ToList().Find(p => p.Id == id);
            _db.Planes.Remove(planes);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
