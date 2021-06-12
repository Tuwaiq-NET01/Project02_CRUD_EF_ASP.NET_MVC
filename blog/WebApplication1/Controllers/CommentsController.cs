using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CommentsController : Controller
    {
        private readonly AppDbContext _db;
        public CommentsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("ArticleId","Content","Date")]CommentModel comment, int id)
        {
            if (ModelState.IsValid)
            {
                comment.Date = DateTime.Now;
                comment.ArticleId = id;
                _db.Add(comment);
                _db.SaveChanges();
                return Redirect("~/Article/details/"+id);
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            var comment = _db.Comments.ToList().Find(x => x.Id == id);
            if(id == null || comment == null)
            {
                return Redirect("~/Article/");
            }
            int articleId = comment.ArticleId;
            _db.Remove(comment);
            _db.SaveChanges();
            return Redirect("~/Article/details/" + articleId);
        }
    }
}
