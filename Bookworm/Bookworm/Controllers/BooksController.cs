using Bookworm.Data;
using Bookworm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        // GET: /books
        public IActionResult Index()
        {
            var DbBooks = _db.Books.Include(b => b.Reviews).ToList();
            ViewBag.Books = DbBooks;
            return View();
        }

        // GET: /books/:id
        public IActionResult Details(int? Id)
        {

            var Book = _db.Books.Include(b => b.Reviews)
                .ThenInclude(r=>r.User).
                ThenInclude(u=>u.Profile)
                .Single(b => b.Id == Id);
         
            if (Id == null || Book == null)
            {
                return View("_NotFound");
            }
            ViewBag.Book = Book;
            return View(Book);
        }

        // GET: /books/create
        public IActionResult Create()
        {
            return View();

        }

        // POST: /books/create
        [HttpPost]
        public IActionResult Create([Bind( "Title", "Author", "Cover")] BookModel book)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);

        }

        // GET: /books/edit/id
        public IActionResult Edit(int? Id)
        {

            var Book = _db.Books.ToList().Find(b => b.Id == Id);
            if (Id == null || Book == null)
            {
                return View("_NotFound");
            }

            return View(Book);

        }

        // POST: /books/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id","Title", "Author", "Cover")] BookModel book)
        {

            _db.Books.Update(book);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

        // POST: /books/delete/id
        [HttpPost]
        public IActionResult Delete(int? Id)
        {

            var Book = _db.Books.ToList().Find(b => b.Id == Id);
            if (Id == null || Book == null)
            {
                return View("_NotFound");
            }
            else
            {
                _db.Books.Remove(Book);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}
