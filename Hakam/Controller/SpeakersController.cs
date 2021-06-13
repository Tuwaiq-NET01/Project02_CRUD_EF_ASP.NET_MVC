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
    public class SpeakersController : ControllerBase
    {
        private readonly AppDbContext Database;
        public SpeakersController(AppDbContext db)
        {
            Database = db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Database.Speakers.ToList());
        }
        [HttpPost]
        public IActionResult Post(SpeakerModel speaker  )
        {

            Database.Speakers.Add(speaker);
            Database.SaveChanges();
            return Created("add db", speaker);
        }
        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete(int ID)
        {
            var Speacker = await Database.Speakers.FindAsync(ID);
            if (ID == null || Speacker == null)
            {
                return NotFound();
            }

            else
            {
                Database.Speakers.Remove(Speacker);
                await Database.SaveChangesAsync();
            }
            return Ok(new { massage = "Delate" });
        }
        [HttpPut("{ID}")]
        public IActionResult Put(int? ID, SpeakerModel speaker)
        {
            if (!Database.Speakers.Any(user => speaker.Speaker_ID == ID))
                return NotFound();

            if (ID != speaker.Speaker_ID)
                return BadRequest();
            Database.Entry(speaker).State = EntityState.Modified;
            Database.SaveChanges();

            return Ok(new { message = " updated" });

        }
    }
}
