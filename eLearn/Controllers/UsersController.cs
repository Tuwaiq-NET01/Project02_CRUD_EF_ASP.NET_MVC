using eLearn.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Controllers
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
            var Users = _db.User.ToList();
            ViewData["Users"] = Users;
            return View();
        }
    }
}
