using Bookworm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookworm.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _db;

        public ReviewsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbReviews = _db.Reviews.Include(b => b.Book).Include(u => u.User.Profile).ToList();
            ViewBag.Reviews = DbReviews;
            return View();
        }
    }
}
