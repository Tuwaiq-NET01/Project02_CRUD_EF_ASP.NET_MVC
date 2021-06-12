using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCRUD.Data;
using MovieCRUD.Models;

namespace MovieCRUD.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UsersController : Controller
    {
        private readonly AppDbContext _db;
        // GET
        public UsersController(AppDbContext context)
        {
            this._db = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUsers()
        {
            return await _db.Users.ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<dynamic>> GetUser(int id)
        {
            return await _db.Users.Where(User => User.Id == id).ToListAsync();
        }    }
}