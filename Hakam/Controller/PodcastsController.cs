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

    public class PodcastsController : ControllerBase
    {
        private readonly AppDbContext Database;
        public PodcastsController(AppDbContext db)
        {
            Database = db;

        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Database.Podcasts.ToList());
        }
        [HttpPost]
        public IActionResult Post(PodcastModel podcast)
        {

            Database.Podcasts.Add(podcast);
            Database.SaveChanges();
            return Created("add db", podcast);
        }
        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete(int ID)
        {
            var podcast = await Database.Podcasts.FindAsync(ID);
            if (ID == null || podcast == null)
            {
                return NotFound();
            }
            else
            {
                Database.Podcasts.Remove(podcast);
                await Database.SaveChangesAsync();
            }
            return Ok(new { massage = "Delate" });
        }
        [HttpPut("{ID}")]
        public IActionResult Put(int? ID, PodcastModel podcast)
        {
            if (!Database.Podcasts.Any(user => podcast.Podcast_ID == ID))
            return NotFound();
            if (ID != podcast.Podcast_ID)
            return BadRequest();
            Database.Entry(podcast).State = EntityState.Modified;
            Database.SaveChanges();
            return Ok(new { message = " updated" });

        }

    }
}
