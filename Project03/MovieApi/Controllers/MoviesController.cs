using Microsoft.AspNetCore.Mvc;
using Project03.Models;
//using Project03.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{
		//database context
		private readonly Project03.Data.AppDbContext _db;
		public MoviesController(Project03.Data.AppDbContext context)
		{
			_db = context;

		}

		// GET: api/<MoviesController>
		[HttpGet]
		public List<Movie> Get()
		{
			return _db.Ms.ToList();
		}

		// GET api/<MoviesController>/5
		[HttpGet("{id}")]
		public Movie Get(int id)
		{
			var movie = _db.Ms.ToList().Find(m => m.Id == id);

			return movie;
		}

		// POST api/<MoviesController>
		[HttpPost]
		public void Post([Bind("Title, Poster, Description, Rating, Cast")] Movie movie)
		{
			try
			{
				if (ModelState.IsValid)
				{
					_db.Ms.Add(movie);
					_db.SaveChanges();
				
				}
			}
			catch (DataException)
			{

			}
		}

		// PUT api/<MoviesController>/5
		[HttpPut("{id}")]
		public void Put([Bind("Id, Title, Poster, Description, Rating, Cast")] Movie m)
		{
			_db.Ms.Update(m);
			_db.SaveChanges();
		}

		// DELETE api/<MoviesController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			var movie = _db.Ms.ToList().FirstOrDefault(m => m.Id == id);
			_db.Ms.Remove(movie);
			_db.SaveChanges();
		}
	}
}
