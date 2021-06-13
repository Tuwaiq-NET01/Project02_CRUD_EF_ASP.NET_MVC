using System.Collections.Generic;
using System.Linq;
using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }
        
        // GET api/categories
        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        // GET api/categories/2
        [HttpGet("{id}")]
        public ActionResult<Category> GetCategories(int id)
        {
            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }
            
            return category;
        }

        // POST api/categories
        [HttpPost]
        public ActionResult<Category> Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return CreatedAtAction("GetCategories", new {id = category.Id}, category);
        }
        
        
        // PUT api/categories/5
        [HttpPut("{id}")]
        public ActionResult<Category> Update(int id, Category updatedCategory)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            category = updatedCategory;
            _context.Categories.Update(category);
            _context.SaveChanges();
            return CreatedAtAction("GetCategories", new {id = category.Id}, category);
        }

        // DELETE api/categories/5
        [HttpDelete("{id}")]
        public ActionResult<Category> Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();
            return Ok();
        }
    }
}