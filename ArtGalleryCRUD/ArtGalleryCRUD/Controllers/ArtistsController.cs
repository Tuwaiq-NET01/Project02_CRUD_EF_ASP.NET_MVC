using ArtGalleryCRUD.Data;
using ArtGalleryCRUD.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryCRUD.Controllers
{
    public class ArtistsController : Controller

    {
        private readonly AppDbContext _db;

        public ArtistsController(AppDbContext context)
        {
            _db = context;
        }

        //<<Read>>
        //Get: /Artists
        public IActionResult Index()
        {
            var Artists = _db.Artists.ToList();
            ViewData["Artists"] = Artists;
            return View();
        }

        //Get: /Artists/details/id


        public IActionResult Details(int? id)
        {
            var Artist = _db.Artists.ToList().Find(a =>a.ArtId == id);
            if (id == null || Artist == null)
            {
                return View("_NotFound");
            }
            ViewData["Artist"] = Artist;

            return View();
        }

        //<<Create>>
        //GET: /artists/create
        public IActionResult Create()
        {
            return View("Create");

        }

        //Post -/artists/create
        [HttpPost]
        public IActionResult Create([Bind( "ArtName", "ArtImg", "ArtBio")] ArtistModel artist)
        {
            if (ModelState.IsValid) //validation check the state of the model
            {
                _db.Artists.Add(artist);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }


 
            return View(artist);
        }


        //GEt: /artists/edit/id
        public IActionResult Edit(int? id)
        {
            var Artist = _db.Artists.ToList().Find(a => a.ArtId == id);
            if (id == null || Artist == null)
            {
                return View("_NotFound");
            }
            ViewData["Artist"] = Artist;
            return View();
        }

        //Post: /artists/edit/id
        [HttpPost]
        public IActionResult Edit(int id, [Bind("ArtName", "ArtImg", "ArtBio")] ArtistModel artist)
        {
            var Artist = _db.Artists.ToList().Find(a => a.ArtId == id);
            // update new vals
            Artist.ArtName = artist.ArtName;
            Artist.ArtBio = artist.ArtBio;
            Artist.ArtImg = artist.ArtImg;
            _db.Artists.Update(Artist);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }


        //POST - /artists/delete/id
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var artist = _db.Artists.ToList().FirstOrDefault(a => a.ArtId == id);

           
            // delete vals

            _db.Artists.Remove(artist);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }

       

    }
}
