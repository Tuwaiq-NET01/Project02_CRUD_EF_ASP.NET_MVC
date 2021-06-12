using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_DB_Project.data;
using MVC_DB_Project.Models;

namespace MVC_DB_Project.Controllers
{
    public class PlayersController : Controller
    {
        private readonly AppDbContext _db;

        
        public PlayersController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var searchbyId = _db.Players.SingleOrDefault(a => a.Id == 2);
            var searchbynum = _db.Players.Where(a => a.number > 7).ToList();
            ViewData["sId"] = searchbyId;
            ViewData["sNum"] = searchbynum;

            var Players = _db.Players.ToList();
            ViewData["Players"] = Players;
            return View();
        }

            public IActionResult Details(int? id)
        {
            var player = _db.Players.ToList().Find(player => player.Id == id);
            if (id == null || player == null)
            {
                return View("_NotFound");
            }
            ViewData["player"] = player;
            return View(player);
        }


        // Get - /Products/Create
        public IActionResult Create() // ذي عشان بس توديك للكريت حق البوست وتعبي الفورم
        {
            return View();
        }

        // Post - /products/create
        [HttpPost]
        public IActionResult Create([Bind("Id", "name", "number", "CoacheId", "TeamId", "LeagueId")] PlayerModel player) 
        {
            if (ModelState.IsValid) 
            {
                _db.Players.Add(player); 
                _db.SaveChanges();
                return RedirectToAction("Index"); 

            }
            return View();

        }
        // Get - /products/edit/id
        public IActionResult Edit(int id)
        {
            var player = _db.Players.ToList().Find(p => p.Id == id); 
            if (id == null || player == null)
            {
                return View("_NotFound");
            }
            ViewData["player"] = player;
            return View();
        }

        // POST - /products/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id", "name", "number", "CoacheId", "TeamId", "LeagueId")] PlayerModel player)
        {
            _db.Players.Update(player);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
        // Post - /products/delete/id
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var player = _db.Players.ToList().Find(p => p.Id == id);
            if (id == null || player == null)
            {
                return View("_NotFound");
            }
            _db.Players.Remove(player);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
       



