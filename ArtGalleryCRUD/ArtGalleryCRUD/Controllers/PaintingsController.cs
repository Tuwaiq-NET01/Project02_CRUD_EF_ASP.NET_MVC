using ArtGalleryCRUD.Data;
using ArtGalleryCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryCRUD.Controllers
{
    public class PaintingsController : Controller
    {
        private readonly AppDbContext _db;

        public PaintingsController(AppDbContext context)
        {
            _db = context;
        }

        //Get: /Paintings
        public IActionResult Index()
        {
            var Paintings = _db.Paintings.ToList();
            ViewData["Paintings"] = Paintings;
            return View();

        }

        //Get: /Paintings/details
       

        public IActionResult Details(int? id)
        {
            var Painting = _db.Paintings.ToList().Find(p => p.PntId == id);
            if (id == null || Painting == null)
            {
                return View("_NotFound");
            }
            ViewData["Painting"] = Painting;
         

            return View();
        }


        //<<Create>>
        //GET: /paunting/create
        public IActionResult Add()
        {
            return View("ADD");

        }

        //Post -/paintings/create
        [HttpPost]
        public IActionResult Add([Bind("PntName", "PntImg", "PntOverview", "PntPrice")] PaintingModel painting)
        {
            if (ModelState.IsValid) //validation check the state of the model
            {
                _db.Paintings.Add(painting);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }



            return View(painting);
        }

        //GEt: /paintings/edit/id
        public IActionResult Edit(int? id)
        {
            var Painting = _db.Paintings.ToList().Find(p => p.PntId == id);
            if (id == null || Painting == null)
            {
                return View("_NotFound");
            }
            ViewData["Painting"] = Painting;
            return View();
        }

        //Post: /paintings/edit/id
        [HttpPost]
        public IActionResult Edit(int id, [Bind("PntName", "PntImg", "PntOverview", "PntPrice")] PaintingModel painting)
        {
            var Painting = _db.Paintings.ToList().Find(p => p.PntId == id);
            // update new vals
            Painting.PntName = painting.PntName;
            Painting.PntImg= painting.PntImg;
            Painting.PntOverview = painting.PntOverview;
            Painting.PntPrice = painting.PntPrice;
            _db.Paintings.Update(Painting);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }

        //POST - /paintings/delete/id
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var painting = _db.Paintings.ToList().FirstOrDefault(p => p.PntId == id);


            // delete vals

            _db.Paintings.Remove(painting);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }






    }


}
