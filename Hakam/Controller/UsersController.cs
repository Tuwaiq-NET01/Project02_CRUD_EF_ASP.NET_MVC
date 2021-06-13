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
    public class UsersController : ControllerBase
    {
        private  readonly AppDbContext Database;
        public UsersController(AppDbContext db)
        {
            Database = db;
        }
        //GEt:api/User
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Database.Users.ToList());
        }
        [HttpPost]
        public IActionResult Post(UserModel user)
        {
            Database.Users.Add(user);
            Database.SaveChanges();
            return Created("add db", user);
        }
        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete(int ID)
        {
            var user = await Database.Users.FindAsync(ID);
            if (ID == null || user == null)
            {
                return NotFound();
            }
            else
            {
                Database.Users.Remove(user);
                await Database.SaveChangesAsync();
            }
            return Ok(new { massage = "Delate" });
        }
        [HttpPut("{ID}")]
        public IActionResult Put(int? ID, UserModel user)
        {
            if (!Database.Users.Any(user => user.User_ID == ID))
            return NotFound();
            if (ID != user.User_ID)
            return BadRequest();
            Database.Entry(user).State = EntityState.Modified;
            Database.SaveChanges();
            return Ok(new { message = " updated" });

        }
    }
}
