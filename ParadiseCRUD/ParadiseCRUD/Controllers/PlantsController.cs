using Microsoft.AspNetCore.Mvc;
using ParadiseCRUD.Data;
using ParadiseCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParadiseCRUD.Controllers
{
    public class PlantsController : Controller
    {
        private readonly AppDbContext _db;

        public PlantsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {

            var Plants = _db.Plants.ToList();
            ViewData["Plants"] = Plants;
            return View();
        }

        public IActionResult Details(int? id)
        {
            var Plant = _db.Plants.ToList().Find(a => a.ID == id);

            ViewData["Plant"] = Plant;
            return View();

        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        public IActionResult Create([Bind("ID", "Name", "Image", "Tempreture", "LevelCare", "Place", "Size")] Plant plant)
        {
            if (ModelState.IsValid)
            {
                _db.Plants.Add(plant);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plant);

        }
        public IActionResult Edit(int? id)
        {
            var Plant = _db.Plants.ToList().Find(p => p.ID == id);

            if (id == null || Plant == null)
            {
                return View("_NotFound");
            }
            ViewData["Plant"] = Plant;
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Name", "Image", "Tempreture", "LevelCare", "Place", "Size")] Plant pl)
        {
            var Plant = _db.Plants.ToList().Find(p => p.ID == id);
            Plant.Name = pl.Name;
            Plant.Image = pl.Image;
            Plant.Tempreture = pl.Tempreture;
            Plant.LevelCare = pl.LevelCare;
            Plant.Place = pl.Place;
            Plant.Size = pl.Size;

            _db.Plants.Update(Plant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //POST
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Plant = _db.Plants.ToList().FirstOrDefault(p => p.ID == id);
            if (id == null || Plant == null)
            {
                return View("_NotFound");
            }
            _db.Plants.Remove(Plant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
