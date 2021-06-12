using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarStore.Data;
using CarStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _db; 
        public OrdersController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //var Orders = _db.CarOrderModel.ToList();
            /*var Orders =  (from o in _db.CarOrderModel
              select new
              {
                  Id = o.Id,
                  Chassis = o.Chassis.Type,
                  Engine = o.Engine.Type,
                  Gear = o.Gear.Type,
                  Color = o.Color.Type,
                  Price = o.TotalPrice
              }).ToList();*/
            var Orders = _db.CarOrderModel.Include("Chassis").Include("Engine").Include("Gear").Include("Color").ToList();
            ViewData["Order"] = Orders;

            return View();
        }

        public IActionResult Details(int? id)
        {
            var Order = _db.CarOrderModel.Include("Chassis").Include("Engine").Include("Gear").Include("Color").
                ToList().Find(order => order.Id == id);
            if (id == null || Order == null)
            {
                return View("_NotFound");
            }
            ViewData["Order"] = Order;
            return View(Order);

        }

        public IActionResult Create()
        {
            var Chassis = _db.Chassis.ToList();
            ViewData["Chassis"] = Chassis;
            var Engine = _db.Engine.ToList();
            ViewData["Engine"] = Engine;
            var Gear = _db.Gear.ToList();
            ViewData["Gear"] = Gear;
            var Color = _db.Color.ToList();
            ViewData["Color"] = Color;
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("Id", "ChassisId", "EngineId", "GearId", "ColorId", "TotalPrice")] CarOrderModel Order)
        {
            if(ModelState.IsValid)
            {
                /*var chasPrice = _db.Chassis.ToList().Find(chas => chas.Id == Order.ChassisId);
                var engPrice = _db.Engine.ToList().Find(e => e.Id == Order.EngineId);
                var gearPrice = _db.Gear.ToList().Find(e => e.Id == Order.GearId);
                var colorPrice = _db.Color.ToList().Find(e => e.Id == Order.ColorId);
                Order.TotalPrice = chasPrice.Price + engPrice.Price + gearPrice.Price + colorPrice.Price;*/
                _db.CarOrderModel.Add(Order);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Edit(int? id)
        {
            var Chassis = _db.Chassis.ToList();
            ViewData["Chassis"] = Chassis;
            var Engine = _db.Engine.ToList();
            ViewData["Engine"] = Engine;
            var Gear = _db.Gear.ToList();
            ViewData["Gear"] = Gear;
            var Color = _db.Color.ToList();
            ViewData["Color"] = Color;
            var Order = _db.CarOrderModel.ToList().Find(order => order.Id == id);
            if(id == null || Order == null)
            {
                return View("_NotFound");
            }
            ViewData["Order"] = Order;
            return View();
        }


        [HttpPost]
        public IActionResult Edit([Bind("Id", "ChassisId", "EngineId", "GearId", "ColorId", "TotalPrice")] CarOrderModel Order)
        {
            _db.CarOrderModel.Update(Order);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Order = _db.CarOrderModel.ToList().Find(order => order.Id == id);
            if (id == null || Order == null)
            {
                return View("_NotFound");
            }
            _db.CarOrderModel.Remove(Order);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
