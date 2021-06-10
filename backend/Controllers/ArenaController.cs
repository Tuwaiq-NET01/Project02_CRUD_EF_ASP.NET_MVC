using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokeWars.Models;
using backend.Models.Data;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArenaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ArenaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Arena
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Arena>>> GetArena()
        {
            return await _context.Arena.ToListAsync();
        }

        // GET: api/Arena/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Arena>> GetArena(int id)
        {
            var arena = await _context.Arena.FindAsync(id);

            if (arena == null)
            {
                return NotFound();
            }

            return arena;
        }

        // PUT: api/Arena/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArena(int id, Arena arena)
        {
            if (id != arena.Id)
            {
                return BadRequest();
            }

            _context.Entry(arena).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArenaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Arena
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Arena>> PostArena(Arena arena)
        {
            _context.Arena.Add(arena);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArena", new { id = arena.Id }, arena);
        }

        // DELETE: api/Arena/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArena(int id)
        {
            var arena = await _context.Arena.FindAsync(id);
            if (arena == null)
            {
                return NotFound();
            }

            _context.Arena.Remove(arena);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArenaExists(int id)
        {
            return _context.Arena.Any(e => e.Id == id);
        }
    }
}
