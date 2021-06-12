using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Logistic.Models;

namespace Logistic.Controllers
{
    public class ProductsController : Controller
    {
        private readonly logisticContext _context;

        public ProductsController(logisticContext context)
        {
            _context = context;
        }

        // GET: Products
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            ViewData["products"] = products;
            return View();
        }

        // GET: Products/Details/id
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Products.FirstOrDefault(m => m.Id == id);

            ViewData["product"] = product;
            if (product == null)
            {
                return NotFound();
            }
            return View();
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public IActionResult Create([Bind("Id,Name,Description,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Edit/id
        public IActionResult Edit(int? id)
        {
            var product = _context.Products.ToList().Find(p => p.Id == id);
            if (id == null || product == null)
            {
                return View("_NotFound");
            }
            ViewData["product"] = product;
            return View();
        }

        // POST: Products/Edit/id
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,Name,Description,Price")] Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Products/Delete/id
        public IActionResult Delete(int? id)
        {
            var product = _context.Products.ToList().Find(p => p.Id == id);
            if (id == null || product == null)
            {
                return View("_NotFound");
            }
            ViewData["product"] = product;
            return View();
        }

        // GET: Products/Delete/id
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var Product = _context.Products.ToList().FirstOrDefault(p => p.Id == id);
            _context.Remove(Product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
