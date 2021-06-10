using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokeWars.Models;
using backend.Models.Data;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RankController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Rank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rank>>> GetRank()
        {
            return await _context.Rank.ToListAsync();
        }

        // GET: api/Rank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rank>> GetRank(int id)
        {
            var rank = await _context.Rank.FindAsync(id);

            if (rank == null)
            {
                return NotFound();
            }

            return rank;
        }

        // PUT: api/Rank/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRank(int id, Rank rank)
        {
            if (id != rank.Id)
            {
                return BadRequest();
            }

            _context.Entry(rank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RankExists(id))
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

        // POST: api/Rank
        [HttpPost]
        public async Task<ActionResult<Rank>> PostRank(Rank rank)
        {
            _context.Rank.Add(rank);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRank", new { id = rank.Id }, rank);
        }

        // DELETE: api/Rank/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRank(int id)
        {
            var rank = await _context.Rank.FindAsync(id);
            if (rank == null)
            {
                return NotFound();
            }

            _context.Rank.Remove(rank);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RankExists(int id)
        {
            return _context.Rank.Any(e => e.Id == id);
        }
    }
}
