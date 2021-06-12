using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tuwaiq_Student_Life.Data;

namespace Tuwaiq_Student_Life.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDBContext _db;

        public StudentController(AppDBContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var Students = _db.Students.ToList();
            ViewData["Students"] = Students;
            return View();
        }
    }
}
