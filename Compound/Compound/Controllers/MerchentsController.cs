using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compound.Models;
using Compound.Data;


namespace Compound.Controllers
{
    public class MerchentsController : Controller
    {
        private readonly AppDbContext _db;
        public MerchentsController(AppDbContext dp)
        {
            _db = dp;
        }
        // READ -GET /Merchents
        public IActionResult Index()
        {
            var merchents = _db.Merchents.ToList();
            ViewData["Merchent"] = merchents;
            return View(merchents);
        }
        // GET: /Merchents/id
        public IActionResult Details(int? id)
        {
            var details = _db.Merchents.ToList().Find(details => details.Id == id);
            if (id == null || details == null)
            {
                return View("_NotFound");
            }
            ViewData["Details"] = details;
            return View(details);
        }
        //GET - /Merchents/create
        public IActionResult Create()
        {
            return View();
        }
        //POST - /Merchents/create
        [HttpPost]
        public IActionResult Create([Bind("Id", "Name", "Description", "Price")] Merchent merch)
        {
            if (ModelState.IsValid)
            {
                _db.Merchents.Add(merch);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }
        //GET - /Merchents/edit/id
        public IActionResult Edit(int? id)
        {
            var merchents = _db.Merchents.ToList().Find(a => a.Id == id);
            if (id == null || merchents == null)
            {
                return View("_NotFound");
            }
            ViewData["Merchent"] = merchents;
            return View();
        }
        //POST - /Merchents/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id", "Name", "Description", "Price")] Merchent merch)
        {
            _db.Merchents.Update(merch);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // POST - /Appointments/delete/id
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var merchent = _db.Merchents.ToList().Find(a => a.Id == id);
            _db.Merchents.Remove(merchent);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
