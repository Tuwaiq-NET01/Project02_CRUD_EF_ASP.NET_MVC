using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_DB_Project.data;

namespace MVC_DB_Project.Controllers
{
    public class TeamsController : Controller
    {
        private readonly AppDbContext _db;


        public TeamsController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            

            var Teams = _db.Teams.ToList();
            ViewData["Teams"] = Teams;
            return View();
        }

    }
}
