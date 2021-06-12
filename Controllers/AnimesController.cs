using CRUD_ASP_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP_PROJECT.Controllers
{
    public class AnimesController : Controller
    {
        private readonly MyDataBaseContext _db;

        public AnimesController(MyDataBaseContext db)
        {
            _db = db;
        }

        //GET /Animes
        public IActionResult Index()
        {
            var Animes = _db.Animes.ToList();
            ViewData["Animes"]=Animes;
            return View();
        }

        public IActionResult Details(int? id)
        {
            var Anime = _db.Animes.ToList().Find(anime => anime.Id == id);
            if (id==null||Anime==null)
            {
                return View("_NotFound");
            }
            ViewData["Anime"] = Anime;
            return View();
        }

        //GET - /Animes/Add
        public IActionResult Add()
        {
            var Animes = _db.Animes.ToList();
            ViewData["Animes"] = Animes;
            return View();
        }

        //POST - /Animes/Add
        [HttpPost]
        public IActionResult Add([Bind("Id", "Title", "Image", "Story", "Video")]AnimeModel anime)
        {
            if (ModelState.IsValid)
            {
                _db.Animes.Add(anime);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }



        //GET - /Animes/Edit/id
        public IActionResult Edit(int? id)
        {
            var Anime = _db.Animes.ToList().Find(anime => anime.Id == id);
            if (id==null||Anime==null)
            {
                return View("_NotFound");
            }
            ViewData["Anime"] = Anime;
            return View();
        }

        //POST - /Animes/Edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id", "Title", "Image", "Story", "Video")]AnimeModel anime)
        {
            _db.Animes.Update(anime);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        //POST - /Animes/Delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Anime = _db.Animes.ToList().Find(anime => anime.Id == id);
            if (id == null || Anime == null)
            {
                return View("_NotFound");
            }
            _db.Animes.Remove(Anime);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
