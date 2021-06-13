using Microsoft.AspNetCore.Mvc;
using Project3_Hotel.Data;
using Project3_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3_Hotel.Controllers
{
    public class RoomsController : Controller
    {
        private readonly AppDbContext _db;

        public RoomsController(AppDbContext db)
        {
            _db = db;
        }

        //GET:/Rooms

        public IActionResult Index()
        {
            var rooms = _db.Room.ToList();
            ViewData["rooms"] = rooms;
            return View();
        }
        //Get: /rooms/id
        public IActionResult Details(int id)
        {
            var room = _db.Room.ToList().Find(p => p.RoomNumber == id);
            if (id == null ||  room == null)
            {
                return View("_NotFound");
            }
            ViewData["room"] = room;

            return View(room);
        }

        //GET - /rooms/create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("RoomNumber", "RoomType", "RoomRate", "RoomLocation", "NumberOfBeds", "HotelId")] Room room)
        {
            if (ModelState.IsValid)//check the state of the model
            {
                _db.Room.Add(room);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(room);

        }

        //GET: /rooms/edit/id
        public IActionResult Edit(int? id)
        {
            var room = _db.Room.ToList().Find(r => r.RoomNumber == id);
            if (id == null || room == null)
            {
                return View("_NotFound");
            }
            ViewData["room"] = room;
            return View();
        }

        //POST: /Hotels/edit/id
        [HttpPost]
        public IActionResult Edit(int id,[Bind("RoomType", "RoomLocation", "RoomRate", "NumberOfBeds")] Room r)
        {
            var room = _db.Room.ToList().Find(p => p.RoomNumber == id);

            room.RoomType = r.RoomType;
            room.RoomRate = r.RoomRate;
            room.RoomLocation = r.RoomLocation;
            room.NumberOfBeds = r.NumberOfBeds;
            _db.Room.Update(room);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        //POST - /Rooms/delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var room = _db.Room.ToList().FirstOrDefault(h => h.RoomNumber== id);
            if (id == null || room == null)
            {
                return View("_NotFound");
            }
            _db.Room.Remove(room);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
