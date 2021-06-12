using GroceryStore.Data;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Branches()
        {


            var Branches = _db.Branches.ToList();

            ViewData["Branches"] = Branches;

            return View();
        }

        public IActionResult Customers()
        {


            var Customers = _db.Customers.ToList();

            ViewData["Customers"] = Customers;

            return View();
        }

        public IActionResult Products()
        {


            var Products = _db.Products.ToList();

            ViewData["Products"] = Products;

            return View();
        }

        public IActionResult Search(string txt)
        {
            var product = _db.Products.Where(product => product.Name.Contains(txt)).ToList();
            ViewBag.Products = product;

            return View("Products");
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
