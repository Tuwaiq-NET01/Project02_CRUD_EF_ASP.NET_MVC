using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NadaMVC.Models;
using NadaMVC.Data;

namespace NadaMVC.Controllers
{
    public class BookController : Controller
    {
        public List<BookModel> Book = new List<BookModel>()
        {

        new BookModel (1,"Roald Dahl", "The BFG",1982,"https://upload.wikimedia.org/wikipedia/ar/thumb/b/b2/The_BFG_%28Dahl_novel_-_cover_art%29.jpg/227px-The_BFG_%28Dahl_novel_-_cover_art%29.jpg"),
        new BookModel(2,"Jeff Kinney", "Diary of a Wimpy Kid",2007, "https://upload.wikimedia.org/wikipedia/ar/0/09/Diary_of_a_wimpy_kid.jpg"),
        new BookModel (3,"Antoine De Saint","The Little Prince",2016, "https://images-na.ssl-images-amazon.com/images/I/4186P0mACWL._SX336_BO1,204,203,200_.jpg"),
        new BookModel (4,"Markus Zusak","The Book Thief",2016, "https://images-na.ssl-images-amazon.com/images/I/41LxDicrz2L._SX334_BO1,204,203,200_.jpg"),
        new BookModel (5,"Gareth Moore","Brain Games for Clever Kids",2014, "https://images-na.ssl-images-amazon.com/images/I/51WAKxhIoyL._SX328_BO1,204,203,200_.jpg"),

            };
        private readonly AppDbContext _db;

        public BookController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /Book/
        // GET: /Book/index

        public IActionResult Index()
        {


            ViewData["Book"] = Book;
            return View();
        }
        public IActionResult Type()
        {
            return View();
        }
        // GET: /Book/details/id
        public IActionResult Details(int? id)
        {
            BookModel Books = Book.Find(ID => ID.BookId == id);
            if (Books == null)
            {
                return Content("There is no book try another ID ");

            }
            else
            {
                ViewData["Book"] = Books;
                return View();

            }


        }
        public IActionResult Create()
        {

            return View("Create");
        }

        [HttpPost]
        public IActionResult Create([Bind("BookId", "Author", "Title", "Published", "image")] BookModel Book)
        {
            if (ModelState.IsValid)
            {
                _db.Book.Add(Book);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }

        public IActionResult Edit(int? id)
        {
            var Books = _db.Book.ToList().Find(p => p.BookId == id);


            if (id == null || Books == null)
            {
                return View("_NotFound");
            }
            ViewData["Book"] = Books;
            return View();
        }

        [HttpPost]
        public IActionResult Edit([Bind("BookId", "Author", "Title", "Published", "image")] BookModel Book)
        {

            _db.Book.Update(Book);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Books = _db.Book.ToList().FirstOrDefault(p => p.BookId == id);

            if (id == null || Books == null)
            {
                return View("_NotFound");
            }
            _db.Book.Remove(Books);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}






 