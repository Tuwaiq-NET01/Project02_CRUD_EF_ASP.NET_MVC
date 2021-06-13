using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Data;
using StudentApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly AppDbContext _Db;

        public QuestionController(AppDbContext appDb)
        {
            this._Db = appDb;
        }
        // GET: /<controller>/
        [Route("{id:int}")]
        [HttpGet]
        public List<Question> Get(int? id)
        {
            var Questions = _Db.Questions.Where(q=>q.CourseId==id).ToList();

            return Questions;
        }
        
 }
}




