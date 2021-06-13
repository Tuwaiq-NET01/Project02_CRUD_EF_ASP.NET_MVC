using System.Collections.Generic;
using System.Linq;
using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : Controller
    {
        private readonly AppDbContext _context;

        public PagesController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public IEnumerable<Page> GetPages()
        {
            return _context.Pages.Include(c=>c.Category)
                .Include(b=>b.Blocks).ToList();
        }

        // GET /api/pages/5
        [HttpGet("{id}")]
        public ActionResult<Page> GetPages(int id)
        {
            var page = _context.Pages.Include(b => b.Blocks).FirstOrDefault(p => p.Id == id);

            if (page == null)
            {
                return NotFound();
            }

            return page;
        }

        [HttpPost]
        public ActionResult<Page> Create(Page page)
        {
            _context.Pages.Add(page);
            _context.SaveChanges();
           return CreatedAtAction("GetPages", new {id = page.Id}, page);
        }

        // PUT api/pages/5
        [HttpPut("{id}")]
        public ActionResult<Page> Update(int id, Page updatedPage)
        {
            var page = _context.Pages.FirstOrDefault(p => p.Id == id);

            if (page == null)
            {
                return NotFound();
            }

            page = updatedPage;
            _context.Pages.Update(page);
            _context.SaveChanges();
            return CreatedAtAction("GetPages", new {id = page.Id}, page);
        }

        // DELETE api/categories/5
        [HttpDelete("{id}")]
        public ActionResult<Category> Delete(int id)
        {
            var page = _context.Pages.FirstOrDefault(p => p.Id == id);

            if (page == null)
            {
                return NotFound();
            }

            _context.Pages.Remove(page);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}/blocks")]
        public ActionResult<IEnumerable<Block>> GetBlocks(int id)
        {
            var page = _context.Pages.Find(id);

            if (page == null)
            {
                return NotFound();
            }

            return page.Blocks.ToList();
        }


        [HttpPost("{pageId}/blocks")]
        public ActionResult<Page> AddBlock(int pageId, Block block)
        {
            var page = _context.Pages.Find(pageId);

            if (page == null)
            {
                return NotFound();
            }

            block.PageId = page.Id;

            _context.Blocks.Add(block);
            _context.SaveChanges();
            return CreatedAtAction("GetBlocks", new {id = block.Id}, block);
        }

        [HttpPost("{pageId}/blocks/update")]
        public ActionResult<Page> UpdateBlocks(int pageId, IEnumerable<Block> blocks)
        {
            var page = _context.Pages.Find(pageId);

            if (page == null)
            {
                return NotFound();
            }

            page.Blocks = blocks;
            _context.Pages.Update(page);
            _context.SaveChanges();
            return CreatedAtAction("GetBlocks", new {id = page.Id}, page);
        }
    }
}