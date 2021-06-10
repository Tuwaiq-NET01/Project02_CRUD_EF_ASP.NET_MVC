using Bookworm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookworm.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _db;

        public BooksController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbBooks = _db.Books.Include(b => b.Reviews).ToList();
            ViewBag.Books = DbBooks;
            return View();
        }

        public IActionResult Details(int Id)
        {
            var DbBook = _db.Books.Where(b => b.Id.Equals(Id)).Include(b => b.Reviews).ThenInclude(r => r.User.Profile);
            ViewBag.Book = DbBook;
            return View();
        }
    }
}
