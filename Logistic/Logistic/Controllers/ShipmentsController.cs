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
    public class ShipmentsController : Controller
    {
        private readonly logisticContext _context;

        public ShipmentsController(logisticContext context)
        {
            _context = context;
        }

        // GET: Shipments
        public IActionResult Index()
        {
            var shipments = _context.Shipments.ToList();
            ViewData["shipments"] = shipments;

            var customers = _context.Customers.ToList();
            ViewData["customers"] = customers;

            var products = _context.Products.ToList();
            ViewData["products"] = products;
            return View();
        }

        // GET: Shipments/Details/id
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipment = _context.Shipments.FirstOrDefault(m => m.Id == id);

            ViewData["shipment"] = shipment;
            if (shipment == null)
            {
                return NotFound();
            }
            return View();
        }

        // GET: Shipments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shipments/Create
        [HttpPost]
        public IActionResult Create([Bind("Id,DateOfDelivery,LocationOfDelivery,CustomerId,ProductId")] Shipment shipment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shipment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shipment);
        }

        // GET: Shipments/Edit/id
        public IActionResult Edit(int? id)
        {
            var shipment = _context.Shipments.ToList().Find(p => p.Id == id);
            if (id == null || shipment == null)
            {
                return View("_NotFound");
            }
            ViewData["shipment"] = shipment;
            return View();
        }

        // POST: Shipments/Edit/id
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,DateOfDelivery,LocationOfDelivery,CustomerId,ProductId")] Shipment shipment)
        {
            _context.Update(shipment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Shipments/Delete/id
        public IActionResult Delete(int? id)
        {
            var shipment = _context.Shipments.ToList().Find(p => p.Id == id);
            if (id == null || shipment == null)
            {
                return View("_NotFound");
            }
            ViewData["shipment"] = shipment;
            return View();
        }

        // GET: Shipments/Delete/id
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var Shipment = _context.Shipments.ToList().FirstOrDefault(p => p.Id == id);
            _context.Remove(Shipment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
