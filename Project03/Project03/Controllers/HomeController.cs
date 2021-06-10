using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project03.Data;
using Project03.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Project03.Controllers
{
	public class HomeController : Controller
	{
		//database context
		private readonly AppDbContext _db;
		public HomeController(AppDbContext context)
		{
			_db = context;

		}

		//GEt - /Home/index
		public IActionResult Index()
		{
			//fetch data
			var Movies = _db.Ms.ToList();
			ViewBag.Movies = Movies;
			return View();
		}

		//GEt - /Home/Details/id
		public ActionResult Details(int? id)
		{
			var movie = _db.Ms.ToList().Find(m => m.Id == id);
			if (id == null || movie == null)
			{
				return View("_NotFound");
			}
			ViewBag.Movie = movie;
			return View(movie);
		}

		//GEt - /Home/Create
		public IActionResult Create()
		{
			return View();
		}

		//POST - /Home/edit/id
		[HttpPost]
		public ActionResult Create([Bind("Title, Poster, Description, Rating, Cast")] Movie movie)
		{
			try
			{
				if (ModelState.IsValid)
				{
					_db.Ms.Add(movie);
					_db.SaveChanges();
					return RedirectToAction("Index");
				}
			}
			catch (DataException)
			{
			
			}
			return View(movie);
		}

		//GEt - /Home/edit/id
		public IActionResult Edit(int? id)
		{
			var movie = _db.Ms.ToList().Find(m => m.Id == id);
			if (id == null || movie == null)
			{
				return View("_NotFound");
			}
			ViewBag.Movie = movie;
			return View();
		}

		//POST - /products/edit/id
		[HttpPost]
		public IActionResult Edit([Bind("Id, Title, Poster, Description, Rating, Cast")] Movie m)
		{
			_db.Ms.Update(m);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}

		// POST - /Home/delete/id
		[HttpPost]
		public IActionResult Delete(int? id)
		{
			var movie = _db.Ms.ToList().FirstOrDefault(m => m.Id == id);
			if (id == null || movie == null)
			{
				return View("_NotFound");
			}
			_db.Ms.Remove(movie);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

