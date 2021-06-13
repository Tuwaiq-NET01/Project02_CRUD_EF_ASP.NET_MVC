using Hospital_project3.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_project3.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _db;

        public DepartmentsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbDepartments = _db.Departments.ToList();
            var Doctors = _db.Physicians.ToList();

            ViewBag.Departments = DbDepartments;
            ViewData["Doctors"] = Doctors;
            return View();
        }
        
    }
}
