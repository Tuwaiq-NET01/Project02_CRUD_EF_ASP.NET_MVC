using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCRUD.Data;
using MovieCRUD.Models;

namespace MovieCRUD.Controllers
{
    public class MoviesApiController : Controller
    {
        private readonly AppDbContext _db;

        public MoviesApiController(AppDbContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetMovies()
        {
            return await _db.Movies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieModel>> GetMovie(int id)
        {
            return await _db.Movies.FindAsync(id);
        }


        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(
            [Bind("id", "backdrop_path", "overview"
                , "poster_path", "release_date", "title", "vote_average", "runtime", "imdb_id")]
            MovieModel Movie)
        {
            Console.WriteLine(Movie.id);
            if (ModelState.IsValid)
            {
                _db.Movies.Add(Movie);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int? id)
        {
            var Movie = _db.Movies.ToList().Find(movie => movie.id == id);

            if (id == null || Movie == null)
            {
                return View("_NotFound");
            }

            return View(Movie);
        }

        [HttpPost ("Edit/{title}")]
        public IActionResult Edit
            ([Bind("id", "backdrop_path", "overview", "poster_path", "release_date", "title", "vote_average", "runtime", "imdb_id")] MovieModel Movie)
        {
            _db.Movies.Update(Movie);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost ("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            var Movie = _db.Movies.ToList().Find(movie => movie.id == id);
            
            if (id == null || Movie == null)
            {
                return View("_NotFound");
            }

            _db.Movies.Remove(Movie);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}