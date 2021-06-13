using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compound.Models;
using Compound.Data;

namespace Compound.Controllers
{
    public class VillasController : Controller
    {
        private readonly AppDbContext _context;

        public VillasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Users = _context.Users.ToList();
            var Villa = _context.Villa.ToList();
            ViewData["Users"] = Users;
            ViewData["Villa"] = Villa;
            return View();
        }
    }
}
