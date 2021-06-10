using Microsoft.AspNetCore.Mvc;
using ParadiseCRUD.Data;
using ParadiseCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParadiseCRUD.Controllers
{
    public class CommunityController : Controller
    {

        private readonly AppDbContext _db;

        public CommunityController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {

            var Comments = _db.Comments.ToList();
            ViewData["Comments"] = Comments;

            return View();
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        public IActionResult Create([Bind("ID", "Name", "Message")] Comment comm)
        {
            if (ModelState.IsValid)
            {
                _db.Comments.Add(comm);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comm);

        }
        public IActionResult Edit(int? id)
        {
            var Comment = _db.Comments.ToList().Find(p => p.ID == id);

            if (id == null || Comment == null)
            {
                return View("_NotFound");
            }
            ViewData["Comment"] = Comment;
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Name", "Message")] Comment comm)
        {
            var Comment = _db.Comments.ToList().Find(p => p.ID == id);
            Comment.Name = comm.Name;
            Comment.Message = comm.Message;
            
            _db.Comments.Update(Comment);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        //POST
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Comment = _db.Comments.ToList().FirstOrDefault(p => p.ID == id);
            if (id == null || Comment == null)
            {
                return View("_NotFound");
            }
            _db.Comments.Remove(Comment);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
