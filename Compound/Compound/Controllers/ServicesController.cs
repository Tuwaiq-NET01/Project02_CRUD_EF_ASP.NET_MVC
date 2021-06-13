using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compound.Models;
using Compound.Data;

namespace Compound.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Services = _context.Services.ToList();
            var Staff = _context.Staff.ToList();
            ViewData["Services"] = Services;
            ViewData["Staff"] = Staff;
            return View();
        }
        public IActionResult Details(int? id)
        {
            var Service = _context.Services.ToList().Find(product => product.Service_Id == id);
            if (id == null || Service == null)
            {
                return View("NotFound");
            }
            ViewData["Service"] = Service;
            return View(Service);
        }

        // GET: Products/Create
        public IActionResult Create()
        {

            return View();
        }

        //Post - /products/create
        [HttpPost]
        public IActionResult Create([Bind("Service_Id", "Service_Name", "StaffId")] ServiceModel service)
        {
            if (ModelState.IsValid)
            { // Validation
                _context.Services.Add(service);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            //i can add here some notification to acknowldge the user of his mistakes
            return View(service);
        }

        //get
        public IActionResult Edit(int? id)
        {
            var Service = _context.Services.ToList().Find(p => p.Service_Id == id);
            if (id == null || Service == null)
            {
                return View("Not Found");
            }
            ViewData["Service"] = Service;
            return View();
        }
        //Post
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Service_Id", "Service_Name")] ServiceModel ser)
        {
            var Service = _context.Services.ToList().Find(p => p.Service_Id == id);
            Service.Service_Id = ser.Service_Id;
            Service.Service_Name = ser.Service_Name;
            

            _context.Services.Update(Service);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Service = _context.Services.ToList().FirstOrDefault(p => p.Service_Id == id);
            _context.Remove(Service);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
