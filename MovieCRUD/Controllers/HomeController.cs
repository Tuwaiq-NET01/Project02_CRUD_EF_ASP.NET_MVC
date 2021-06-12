using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCRUD.Data;
using MovieCRUD.Models;

namespace MovieCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        // GET
        public HomeController(AppDbContext context)
        {
            this._db = context;
        }
        public IActionResult Index()
        {

            @ViewData["Movies"] = _db.Movies.ToList(); 
            

            return View();
        }
        public IActionResult Details(int id)
        {
            var movie = _db.Movies.FirstOrDefault(movie => movie.id == id );
            @ViewData["Movie"] = movie;
            var reviews  =  _db.Reviews.Where(review => review.MovieId == id).ToList();
            
            
            @ViewData["Review"] = reviews;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}