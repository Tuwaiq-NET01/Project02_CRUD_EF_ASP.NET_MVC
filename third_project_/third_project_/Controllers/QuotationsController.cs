using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using third_project_.Data;
using third_project_.Models;

namespace third_project_.Controllers
{
    public class QuotationsController : Controller
    {
        private readonly AppDbContext _db;

        public QuotationsController(AppDbContext context)
        {
            _db = context;
        }
        //GET: /Quotations
        public IActionResult Index()
        {
            var Quotations = _db.Quotations.ToList();
            ViewData["Quotations"] = Quotations;
            return View();
        }
        
        //GET: /Quotations/id
        public IActionResult Details(int? id)
        {
            var Quotation = _db.Quotations.ToList().Find(Quotation => Quotation.Id == id);
            if (id == null || Quotation == null)
            {
                return View("NotFound");
            }
            ViewData["Quotation"] = Quotation;
            return View(Quotation);

        }
        //GET: /Quotations/create
        public IActionResult Create()
        {
            return View();
        }
        //POST: /Quotations/create 
        [HttpPost]
        public IActionResult Create([Bind("Id", "Message", "StudentId")] QuotationModel Quotation)
        {
            if (ModelState.IsValid)
            {
                _db.Quotations.Add(Quotation);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Quotation);
        }

        //GET: /Quotations/edit/id
        public IActionResult Edit(int id)
        {
            var Quotation = _db.Quotations.ToList().Find(b => b.Id == id);
            if (id == null || Quotation == null)
            {
                return View("NotFound");
            }
            ViewData["Quotation"] = Quotation;
            return View();
        }

        //POST:  /Quotation/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id", "Message", "StudentId")] QuotationModel Quotation)
        {
            _db.Quotations.Update(Quotation);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //POST: /Quotation/delete/id
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var Quotation = _db.Quotations.ToList().Find(b => b.Id == id);
            if (id == null || Quotation == null)
            {
                return View("NotFound");
            }
            _db.Quotations.Remove(Quotation);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
