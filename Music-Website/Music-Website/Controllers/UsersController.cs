using Microsoft.AspNetCore.Mvc;
using Music_Website.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Music_Website.Controllers
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
            var Profiles = _db.Profiles.ToList();
            ViewData["Profiles"] = Profiles;

            return View();
        }
    }
}
