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
    [Route("Reviews")]
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _db;
        // GET
        public ReviewsController(AppDbContext context)
        {
            this._db = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewModel>>> GetReviews()
        {
            return await _db.Reviews.ToListAsync();
        }
        
        // Movie Id
        [HttpGet("movie/{id}")]
        public async Task<ActionResult<dynamic>> GetMovieReviews(int id)
        {
            return await _db.Reviews.Where(review => review.MovieId == id).ToListAsync();
        }
        
        // User Id
        [HttpGet("user/{id}")]
        public async Task<ActionResult<dynamic>> GetUserReviews(int id)
        {
            return await _db.Reviews.Where(review => review.UserId == id).ToListAsync();
        }
    }
}