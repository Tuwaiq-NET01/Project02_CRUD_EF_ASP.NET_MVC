using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCRUD.Data;
using MovieCRUD.Models;

namespace MovieCRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : Controller
    {
        private readonly AppDbContext _db;

        public GenreController(AppDbContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenreModel>>> GetGenres()
        {
            return await _db.Genres.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetGenre(int id)
        {
            return await _db.Genres.Where(genre => genre.id == id).ToListAsync();
        }

        [HttpGet("movie/{id}")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetMovieGenre(int id)
        {
            var x = _db.Movies.Join(_db.GenreMovie,
                    movie => movie.id,
                    genreMovie => genreMovie.MovieId,
                    (movie, genreMovie) => new
                    {
                        movieId = movie.id,
                        genreMovie = genreMovie.GenreId,
                    })
                .Where(genres => genres.movieId == id)
                .Join(_db.Genres,
                    movieGenre => movieGenre.genreMovie,
                    genre => genre.id,
                    (arg, genre) => new
                    {
                        genreId = arg.genreMovie,
                        genreName = genre.name
                    }
                ).ToListAsync();
            return await x;
        }
    }
}