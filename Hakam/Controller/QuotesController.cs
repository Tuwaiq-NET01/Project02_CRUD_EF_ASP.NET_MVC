using Hakam.Data;
using Hakam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hakam.Controller
{
    [Route("/[controller]")]
    [ApiController]


    public class QuotesController : ControllerBase
    {
        private readonly AppDbContext Database;
        public QuotesController(AppDbContext db)
        {
            Database = db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Database.Quotes.ToList());
        }
        [HttpPost]
        public IActionResult Post(QuoteModel quote)
        {
            Database.Quotes.Add(quote);
            Database.SaveChanges();
            return Created("add db", quote);
        }
        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete(int ID)
        {
            var qoute = await Database.Quotes.FindAsync(ID);
            if (ID == null || qoute == null)
            {
                return NotFound();
            }

            else
            {
                Database.Quotes.Remove(qoute);
                await Database.SaveChangesAsync();
            }
            return Ok(qoute);
        }
        [HttpPut("{ID}")]
        public IActionResult Put(int? ID, QuoteModel quote) 
        {
            if (!Database.Quotes.Any(quote => quote.Qoute_ID == ID))
                return NotFound();
         
            if (ID != quote.Qoute_ID)
                return BadRequest();
            Database.Entry(quote).State = EntityState.Modified;
            Database.SaveChanges();

               return Ok( new { message=" updated"});

        }

    }
}
