using System.Collections.Generic;
using System.Linq;
using EzzRestaurant.Data;
using EzzRestaurant.Models;
using Microsoft.AspNetCore.Mvc;

namespace EzzRestaurant.Controllers
{
    public class UsersController : Controller
    {
        private AppDbContext _db;

        public UsersController(AppDbContext ctx)
        {
            _db = ctx;
        }
        // GET
        public IActionResult Index()
        {
            var orders = _db.Orders.ToList();
            var products = _db.Products.ToList();
            var joinTable = _db.OrderProduct.ToList();
            var users = _db.Users.ToList();

            ViewBag.Orders = orders;
            ViewBag.Products = products;
            ViewBag.JoinTable = joinTable;
            ViewBag.Users = users;
            return View();
        }
        
        // GET
        public IActionResult Details(int? id)
        {
            var orders = _db.Orders.Where(o => o.UserId == id).ToList();
            
            
            var user = _db.Users.Where(u => u.Id == id).ToList().First();

            ViewBag.Orders = orders;
            ViewBag.User = user;
            return View();
        }
        public IActionResult OrderDetails(int? id)
        {
            var ordersProducts = _db.OrderProduct.Where(o => o.OrderId == id).ToList();

            
            var allproducts = _db.Products.ToList();
            List<ProductModel> products = new List<ProductModel> { };
            foreach (var product in allproducts)
            {
                foreach (var orderprod in ordersProducts)
                {
                    if(product.Id == orderprod.ProductId) products.Add(product);
                }
            }
            
            var order = _db.Orders.First(o => o.Id == id);
            

            ViewBag.OrdersProducts = ordersProducts;
            ViewBag.Products = products;
            ViewBag.Order = order;
            return View();
        }

        public bool IsProduct(int productId, List<OrderProductsModel> joinTables)
        {
            foreach (var j in joinTables)
            {
                if (j.ProductId == productId) return true;
            }
            return false;
        }
    }
}