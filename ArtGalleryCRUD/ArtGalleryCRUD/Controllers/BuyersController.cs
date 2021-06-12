using ArtGalleryCRUD.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGalleryCRUD.Controllers
{
    public class BuyersController : Controller
    {
        private readonly AppDbContext _db;

        public BuyersController(AppDbContext context)
        {
            _db = context;
        }

        //Get: /Buyers
        public IActionResult Index()
        {
            var Buyers = _db.Buyers.ToList();
            ViewData["Buyers"] = Buyers;
            return View();
        }
    }
}
