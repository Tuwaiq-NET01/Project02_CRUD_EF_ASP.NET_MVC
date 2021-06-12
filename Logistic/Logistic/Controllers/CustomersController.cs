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
    public class CustomersController : Controller
    {
        private readonly logisticContext _context;

        public CustomersController(logisticContext context)
        {
            _context = context;
        }

        // GET: Customers
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            ViewData["customers"] = customers;
            return View();
        }

        // GET: Customers/Details/id
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _context.Customers.FirstOrDefault(m => m.Id == id);

            ViewData["customer"] = customer;
            if (customer == null)
            {
                return NotFound();
            }
            return View();
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public IActionResult Create([Bind("Id,FirstName,LastName,Email,Address")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Edit/id
        public IActionResult Edit(int? id)
        {
            var customer = _context.Customers.ToList().Find(p => p.Id == id);
            if (id == null || customer == null)
            {
                return View("_NotFound");
            }
            ViewData["customer"] = customer;
            return View();
        }

        // POST: Customers/Edit/id
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,FirstName,LastName,Email,Address")] Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Customers/Delete/id
        public IActionResult Delete(int? id)
        {
            var customer = _context.Customers.ToList().Find(p => p.Id == id);
            if (id == null || customer == null)
            {
                return View("_NotFound");
            }
            ViewData["customer"] = customer;
            return View();
        }

        // GET: Customers/Delete/id
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var Customer = _context.Customers.ToList().FirstOrDefault(p => p.Id == id);
            _context.Remove(Customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
