using CRUD_Project.Data;
using CRUD_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _db;
        public BooksController(AppDbContext db)
        {
            _db = db;
        }

        // GET: /books
        public IActionResult Index()
        {
            var Books = _db.Books.ToList();
            return Ok(Books);
        }

        // GET: /books/details/id
        [HttpGet("details/{id:int}")]
        public IActionResult Details(int? id)
        {
            var Book = _db.Books.ToList().Find(book => book.Id == id);
            if (id == null || Book == null)
            {
                return NotFound();
            }

            return Ok(Book);
        }

        //POST - /books
        [HttpPost]
        public IActionResult Create([FromBody] BookModel book)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
                return Ok(book);
            }

            return BadRequest();
        }

        //POST - /books
        [HttpPut]
        public IActionResult Edit([FromBody] BookModel book)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Update(book);
                _db.SaveChanges();

                return Ok(book);
            }

            return BadRequest();
        }

        // POST - /books/id
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int? id)
        {
            var Book = _db.Books.ToList().FirstOrDefault(b => b.Id == id);
            if (id == null || Book == null)
            {
                return NotFound();
            }
            _db.Books.Remove(Book);
            _db.SaveChanges();
            return Ok();
        }
    }
}
