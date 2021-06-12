using Microsoft.AspNetCore.Mvc;
using Music_Website.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Music_Website.Models;


namespace Music_Website.Controllers
{
    public class MusicsController : Controller
    {
        private readonly AppDbContext _db;

        public MusicsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index(int id = -1)
        {
            var Musics = _db.Musics.ToList();
            var Rate = _db.Rate.ToList();

            ViewData["Musics"] = Musics;
            ViewData["Rating"] = Rate;
            ViewData["id"] = id;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id", "title", "audio", "Music_image", "description", "ProfileId")]MusicModel music)
        {
            
                _db.Musics.Add(music);
                _db.SaveChanges();
                return RedirectToAction("Index");
           
        }


        public IActionResult Edit(int id)
        {
            var Music = _db.Musics.ToList().Find(p => p.Id == id);
            if (id == null || Music == null)
            {
                return View("Error");
            }
            ViewData["Music"] = Music;
            return View();
        }

        // Post - /poducts/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id", "title", "audio", "Music_image", "description", "ProfileId")] MusicModel music)
        {
            _db.Musics.Update(music);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Music = _db.Musics.ToList().Find(p => p.Id == id);
            if (id == null || Music == null)
            {
                return View("Error");
            }
            _db.Musics.Remove(Music);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            var Musics = _db.Musics.ToList();
            var Rate = _db.Rate.ToList();
            MusicModel Musics1 = Musics.Find(b => b.Id == id);

             if (Musics1 == null)
            {
                return View("Error");
            }
            else
            {
                ViewData["Musics"] = Musics;
                ViewData["Rating"] = Rate;
                ViewData["id"] = id;
                return View();
            }
        }
    }
}
