using EventsHall.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EventsHall.Controllers
{
    public class EventsController : Controller
    {
        private readonly AppDbContext _db;

        public EventsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbEvents = _db.Events.ToList();
            ViewBag.Events = DbEvents;
            return View();
        }
    }
}
