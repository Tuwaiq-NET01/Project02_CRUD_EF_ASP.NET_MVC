using AirportsSystemsCrud.Data;
using AirportsSystemsCrud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportsSystemsCrud.Controllers
{
    public class AirportController : Controller
    {
        private readonly AppDbContext _db;
        public AirportController(AppDbContext context)
        {
            _db = context;
        }
        // GET: AirportController
        public IActionResult Index()
        {
            return View(_db.Airports.ToList());
        }

        // GET: AirportController/Details/5
        public ActionResult Details(int? id)
        {
            var Airport = _db.Airports.ToList().Find(Airport => Airport.Airport_ID == id);
            if (id == null || Airport == null)
            {
                return View("_NotFound");
            }
            ViewData["Airport"] = Airport;
            return View(Airport);
        }

        public IActionResult Create()
        {
            return View();
        }
        // Post: AirportController/Create
        [HttpPost]
        public IActionResult Create([Bind("Airpor_tID", "Airport_Short", "Airport_Name", "Country_City", "Gate")] AirportModel Airport)
        {
            RedirectToAction("Create");
            if (ModelState.IsValid)
            {
                _db.Airports.Add(Airport);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }


        // GET: AirportController/Edit/

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var airportEdit = _db.Airports.ToList().Find(p => p.Airport_ID == id);
            if (id == null || airportEdit == null)
            {
                return View("_NotFound");

            }
            ViewData["Airport"] = airportEdit;
            return View("Edit");
        }
        [HttpPost]
        //POST - /Products/Edit/id
        public IActionResult Edit([Bind("Airport_ID", "Airport_Short", "Airport_Name", "Country_City", "Gate")] AirportModel AirportUp)
        {
            _db.Airports.Update(AirportUp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: AirportController/Delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            Console.WriteLine("Deleting");
            var Airport = _db.Airports.ToList().Find(a => a.Airport_ID == id);
            if (id == null || Airport == null)
            {
                return View("_NotFound");
            }
            _db.Airports.Remove(Airport);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
