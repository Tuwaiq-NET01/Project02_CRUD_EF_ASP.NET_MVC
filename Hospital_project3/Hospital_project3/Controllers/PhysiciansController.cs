using Hospital_project3.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_project3.Controllers
{
    public class PhysiciansController : Controller
    {
        private readonly AppDbContext _db;

        public PhysiciansController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbPhysicians = _db.Physicians.ToList();
            ViewBag.Physicians = DbPhysicians;
            return View();
        }
        public IActionResult Details(int? id)
        {
            var searchbyId = _db.Physicians.FirstOrDefault(a => a.Id == id);
            ViewBag.Physicians = searchbyId;
            return View();
        }
    }
}
