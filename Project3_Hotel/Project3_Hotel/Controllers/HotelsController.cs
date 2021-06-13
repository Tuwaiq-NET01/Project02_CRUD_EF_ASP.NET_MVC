using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_Hotel.Models;
using Project3_Hotel.Data;

namespace Project3_Hotel.Controllers
{
    public class HotelsController : Controller
    {
        private readonly AppDbContext _db;
       
        public HotelsController (AppDbContext db)
        {
            _db = db;
        }

        //GET:/Hotels

        public IActionResult Index()
        {
            var hotels = _db.Hotel.ToList();
            ViewData["hotels"] = hotels;
            return View();
        }
        //Get: /Hotels/id
        public IActionResult Details(int id)
        {
            var hotel = _db.Hotel.ToList().Find(p => p.HotelId == id);
            if(id==null || hotel == null)
            {
                return View("_NotFound");
            }
            ViewData["hotel"] = hotel;

            return View(hotel);
        }

        //GET - /hotels/create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("HotelId", "Name","City", "State","Zipcode","PhoneNumber")] Hotel hotel)
        {
            if(ModelState.IsValid)//check the state of the model
            {
                _db.Hotel.Add(hotel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotel);

        }

        //GET: /Hotels/edit/id
        public IActionResult Edit(int? id)
        {
            var hotel = _db.Hotel.ToList().Find(h => h.HotelId == id);
            if (id == null || hotel == null)
            {
                return View("_NotFound");
            }
            ViewData["hotel"] = hotel;
            return View();
        }

        //POST: /Hotels/edit/id
        [HttpPost]
        public IActionResult Edit(int id,[Bind("Name","City","State","Zipcode","PhoneNumber")] Hotel h)
        {

            var hotel = _db.Hotel.ToList().Find(p => p.HotelId == id);

            hotel.Name = h.Name;
            hotel.City = h.City;
            hotel.State = h.State;
            hotel.Zipcode = h.Zipcode;
            hotel.PhoneNumber = h.PhoneNumber;
            _db.Hotel.Update(hotel);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        
        //POST - /Hotels/delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var hotel = _db.Hotel.ToList().FirstOrDefault(h => h.HotelId == id);
            if(id==null||hotel == null)
            {
                return View("_NotFound");
            }
            _db.Hotel.Remove(hotel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
