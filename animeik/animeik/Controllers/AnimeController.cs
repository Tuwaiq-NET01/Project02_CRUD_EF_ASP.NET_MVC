using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using animeik.Data;
using animeik.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace animeik.Controllers
{
    public class AnimeController : Controller
    {
        private readonly AppDbContext _db;
        public AnimeController(AppDbContext context)
        {
            _db = context;
        }
        // GET
        public IActionResult Index(int id)
        {
            
            // LINQ
            ViewData["list"] = _db.Animes.ToList();
            return View();
        }
        
        
        // LINQ
        public IActionResult Details(int id)
        {
            ViewData["anime"] =_db.Animes.FirstOrDefault(a => a.id == id);
            return View();
        }

        public IActionResult Search(string animeName)
        {
            var aa = _db.Animes.Where(a => a.title.Contains(animeName)).ToList();
            ViewData["list"] = aa;
            return View("Index");
        }

        public Anime Getanime(int id)
        {
            return _db.Animes.FirstOrDefault(a => a.id == id);
        }
        public IActionResult Getanimee(int id)
        {
            return Json(Getanime(id));
        }


        [HttpPost]
        public IActionResult Edit([Bind("id", "title","url","image_url","type","episodes","start_date","end_date","score","Categoryid")]Anime anime)
        {
            _db.Animes.Update(anime);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }   
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _db.Remove(Getanime(id));
            _db.SaveChanges();
            return RedirectToAction("Index");

        }   

        [HttpPost]
        public IActionResult Create([Bind("id", "title","url","image_url","type","episodes","start_date","end_date","score","Categoryid")]Anime anime)
        {
            if (ModelState.IsValid)
            {
                _db.Animes.Add(anime);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}

