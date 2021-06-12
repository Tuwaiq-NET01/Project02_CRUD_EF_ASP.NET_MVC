using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using ArtShowSqlServer.Models;
using ArtShowSqlServer.Data;


namespace ArtShowSqlServer.Controllers
{
    
        public class ArtsitsController : Controller
        {
            private readonly AppDbContext _db;

            public ArtsitsController(AppDbContext db)
            {
                _db = db;

            }
            public IActionResult Index()
            {
                var Artists = _db.Artsits.ToList();

                ViewData["Artists"] = Artists;

                return View();
            }
            public IActionResult Details(int id)
            {
                var Artists = _db.Artsits.ToList();
                var ArtWorks = _db.ArtWorks.ToList();
                ArtsitsModel artist = Artists.Find(artist => artist.Id == id);


                if (artist == null)
                {
                    return Content("Not found Art works");

                }
                else
                {

                    ViewData["Artists"] = artist;
                    ViewData["ArtWorks"] = ArtWorks;
                    return View();
                }
            }
       
    }
    }


