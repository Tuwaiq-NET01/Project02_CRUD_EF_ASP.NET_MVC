using ArtGalleryCRUD.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryCRUD.Controllers
{
    public class GalleriesController : Controller
    {
        private readonly AppDbContext _db;

        public GalleriesController(AppDbContext context)
        {
            _db = context;
        }

        //Get: /Galleries
        public IActionResult Index()
        {
            var Galleries = _db.Galleries.ToList();
            ViewData["Galleries"] = Galleries;
            return View();
        }
    }
}
