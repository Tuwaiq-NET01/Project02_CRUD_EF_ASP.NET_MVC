using Microsoft.AspNetCore.Mvc;
using SupplierProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupplierProject.Models;

namespace SupplierProject.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly AppDbContext _db;

        public SuppliersController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Suppliers = _db.Suppliers.ToList();
            ViewData["Suppliers"] = Suppliers;
            return View();
        }
        public IActionResult Details(int? id)
        {
            var Supplier = _db.Suppliers.ToList().Find(Supplier => Supplier.SupplierID == id);
            if (id == null || Supplier == null)
            {
                return View("_NotFound");
            }
            ViewData["Supplier"] = Supplier;
            return View(Supplier);

        }

        // GET  - /products/create
        public IActionResult Create()
        {
            return View();
        }
        // POST - /products/create
        [HttpPost] // Binding doesn't have to be in order
        public IActionResult Create([Bind("SupplierID", "FirstName", "LastName", "Gender", "Address", "PhoneNumber")] SupplierModel Supplier)
        {
            if (ModelState.IsValid)
            {
                _db.Suppliers.Add(Supplier);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        // GET  - /products/edit/id
        public IActionResult Edit(int id)
        {
            var Supplier = _db.Suppliers.ToList().Find(p => p.SupplierID == id);
            if (id == null || Supplier == null)
            {
                return View("_NotFound");
            }
            ViewData["Supplier"] = Supplier;
            return View();
        }
        // POST - /products/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("SupplierID", "FirstName", "LastName", "Gender", "Address", "PhoneNumber")] SupplierModel Supplier)
        {
            _db.Suppliers.Update(Supplier);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // POST - /products/delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Supplier = _db.Suppliers.ToList().Find(p => p.SupplierID == id);
            if (id == null || Supplier == null)
            {
                return View("_NotFound");
            }
            _db.Suppliers.Remove(Supplier);
            _db.SaveChanges();
            return RedirectToAction("Index"); // => /Suppliers
        }
    }
}
