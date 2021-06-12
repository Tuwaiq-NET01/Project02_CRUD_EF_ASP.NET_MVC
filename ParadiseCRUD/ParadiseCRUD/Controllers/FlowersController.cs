using Microsoft.AspNetCore.Mvc;
using ParadiseCRUD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParadiseCRUD.Models;

namespace ParadiseCRUD.Controllers
{
    public class FlowersController : Controller
    {
        private readonly AppDbContext _db;

        public FlowersController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {

            var Flowers = _db.Flowers.ToList();
            ViewData["Flowers"] = Flowers;
            return View();
        }

        public IActionResult Details(int? id)
        {
            var Flower = _db.Flowers.ToList().Find(a => a.ID == id);

            ViewData["Flower"] = Flower;
            return View();

        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        public IActionResult Create([Bind("ID", "Name", "Image", "Tempreture", "LevelCare", "Place", "Size")] Flower flower)
        {
            if (ModelState.IsValid)
            {
                _db.Flowers.Add(flower);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flower);

        }
        public IActionResult Edit(int? id)
        {
            var Flower = _db.Flowers.ToList().Find(p => p.ID == id);

            if (id == null || Flower == null)
            {
                return View("_NotFound");
            }
            ViewData["Flower"] = Flower;
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Name", "Image", "Tempreture", "LevelCare", "Place", "Size")] Flower flow)
        {
            var Flower = _db.Flowers.ToList().Find(p => p.ID == id);
            Flower.Name = flow.Name;
            Flower.Image = flow.Image;
            Flower.Tempreture = flow.Tempreture;
            Flower.LevelCare = flow.LevelCare;
            Flower.Place = flow.Place;
            Flower.Size = flow.Size;

            _db.Flowers.Update(Flower);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //POST
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Flower = _db.Flowers.ToList().FirstOrDefault(p => p.ID == id);
            if (id == null || Flower == null)
            {
                return View("_NotFound");
            }
            _db.Flowers.Remove(Flower);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

