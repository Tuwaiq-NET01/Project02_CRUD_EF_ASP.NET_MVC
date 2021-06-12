using System;
using System.Collections.Generic;
using System.Linq;
using animeik.Data;
using animeik.Models;
using Microsoft.AspNetCore.Mvc;

namespace animeik.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _db;
        public UsersController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            ViewData["users"] = _db.Users.ToList();
            return View();
        }
        
    }
}