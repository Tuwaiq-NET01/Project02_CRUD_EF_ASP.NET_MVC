using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewData["user"] = _db.Users.ToList().Find(x => x.Id == 1);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
/*
         [HttpPost]
        public IActionResult Signin([Bind("Username", "Password")] UserModel user)
        {
            if (ModelState.IsValid)
            {
             if(_db.Users.ToList().Find(x => (x.Username == user.Username)&&(x.Password == user.Password)) != null)
                {
                    return Content("welcome");//Redirect("/articles");
                }
             else
                {
                    return Content("not found");//Redirect("/articles");
                }
            }
            return View();
        }
 */
