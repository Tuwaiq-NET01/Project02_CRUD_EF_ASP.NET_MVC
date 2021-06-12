using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ArticleController : Controller
    {
        private readonly AppDbContext _db;
        public ArticleController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewData["articles"] = _db.Articles.ToList();
            return View();
        }
        public IActionResult Details(int? id)
        {
            ViewData["article"] = _db.Articles.ToList().Find(x => x.Id == id);
            ViewData["comments"] = _db.Comments.Where(x => x.ArticleId == id).ToList();
            return View();
        }
        //create articles
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("Id", "UserId", "Title","HTMLContent","Date")]ArticleModel article)
        {
            if (ModelState.IsValid)
            {
                article.UserId = 3;
                article.Date = DateTime.Now;
                _db.Articles.Add(article);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }
        public IActionResult Edit(int? id)
        {
            ViewData["article"] = _db.Articles.ToList().Find(x => x.Id == id);
            return View();
        }
        [HttpPost]
        public IActionResult Edit([Bind("Id", "UserId", "Title", "HTMLContent", "Date")] ArticleModel article)
        {
                article.UserId = 3;
                article.Date = DateTime.Now;
                _db.Articles.Update(article);
                _db.SaveChanges();
             return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var article = _db.Articles.ToList().Find(x => x.Id == id);
            if(article == null || id == null)
            {
                return Content("not found");
            }
            _db.Articles.Remove(article);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
