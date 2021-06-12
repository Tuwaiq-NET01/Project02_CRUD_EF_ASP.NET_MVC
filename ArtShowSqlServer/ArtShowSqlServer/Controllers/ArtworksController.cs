using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtShowSqlServer.Models;
using ArtShowSqlServer.Data;

namespace ArtShowSqlServer.Controllers
{
    public class ArtworksController : Controller
    {
        private readonly AppDbContext _db;

        public ArtworksController(AppDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            var ArtWorks = _db.ArtWorks.ToList();

            ViewData["ArtWorks"] = ArtWorks;

            return View();
        }
        public IActionResult Details(int id)
        {
            var Artists = _db.Artsits.ToList();
            var ArtWorks = _db.ArtWorks.ToList();
            ArtWorksModel artWork = ArtWorks.Find(artWork => artWork.Id == id);

            if (artWork == null || id == null)
            {
                return Content("Not found Art works");

            }
            else
            {

                ViewData["ArtWorks"] = artWork;
                ViewData["Artists"] = Artists;
                return View();
            }
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create([Bind("Id", "Title", "Price", "Image", "ArtsitId")] ArtWorksModel artWork)
        {
            if (ModelState.IsValid) //check the state of model
            {
                _db.ArtWorks.Add(artWork);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artWork);
        }
        public IActionResult Edit(int? id)
        {
            var artWork = _db.ArtWorks.ToList().Find(p => p.Id == id);
            if (id == null || artWork == null)
            {
                return View("_NotFound");
            }
            ViewData["artWork"] = artWork;
            return View();
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id", "Title", "Price", "Image", "ArtsitId")] ArtWorksModel artWork)
        {

            _db.ArtWorks.Update(artWork);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var artWork = _db.ArtWorks.ToList().FirstOrDefault(p => p.Id == id);
            if (id == null || artWork == null)
            {
                return View("_NotFound");
            }
            _db.ArtWorks.Remove(artWork);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
