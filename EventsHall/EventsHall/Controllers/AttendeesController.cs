using EventsHall.Data;
using EventsHall.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace EventsHall.Controllers
{
    public class AttendeesController : Controller
    {
        private readonly AppDbContext _db;

        public AttendeesController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbAttendees = _db.Attendees.ToList();
            ViewBag.Attendees = DbAttendees;
            return View();
        }

        public IActionResult Create()
        {

            return View("Create");
        }

        [HttpPost]
        public IActionResult Create([Bind("Name", "Email", "Phone", "Field", "EventId")] AttendeeModel attendee)
        {
            if (ModelState.IsValid)
            {
                _db.Attendees.Add(attendee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }

        public IActionResult Edit(int? id)
        {
            var Attendee = _db.Attendees.ToList().Find(p => p.Id == id);
            if (id == null || Attendee == null)
            {
                return View("_NotFound");
            }
            ViewData["Attendee"] = Attendee;
            return View();
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id","Name", "Email", "Phone", "Field", "EventId")] AttendeeModel attendee)
        {
            _db.Attendees.Update(attendee);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Attendee = _db.Attendees.ToList().FirstOrDefault(p => p.Id == id);
            if (id == null || Attendee == null)
            {
                return View("_NotFound");
            }
            _db.Attendees.Remove(Attendee);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
