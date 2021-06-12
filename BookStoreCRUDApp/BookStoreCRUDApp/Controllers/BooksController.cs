using BookStoreCRUDApp.Data;
using BookStoreCRUDApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCRUDApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _db;

        public BooksController(AppDbContext db)
        {
            _db = db;
        }
        //GET /Books
        public IActionResult Index()
        {
            var Books = _db.Books.ToList();
            ViewData["Books"] = Books;
            return View();
        }
        // GET: /books/id
        public IActionResult Details(int? id)
        {
            var Book = _db.Books.ToList().Find(book => book.BookID == id);
            if (id == null || Book == null)
            {
                return View("_NotFound");
            }
            ViewData["Book"] = Book;
            return View(Book);

        }
        // GET: /books/create
        public IActionResult Create()
        {
            return View();
        }
        //POST -/books/create 
        [HttpPost]
        public IActionResult Create([Bind("BookId", "Title", "Notes", "NoPage", "Price")] BookModel book)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }


        //GET - /books/edit/id
        public IActionResult Edit(int? id)
        {
            var book = _db.Books.ToList().Find(b => b.BookID == id);
            if (id == null || book == null)
            {
                return View("_NotFound");
            }
            ViewData["Book"] = book;
            return View();
        }

        // POST - // book/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("BookId", "Title", "Notes", "NoPage", "Price")] BookModel book)
        {
            _db.Books.Update(book);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //POST -// books/delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var book = _db.Books.ToList().Find(b => b.BookID == id);
            if (id == null || book == null)
            {
                return View("_NotFound");
            }
            _db.Books.Remove(book);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
