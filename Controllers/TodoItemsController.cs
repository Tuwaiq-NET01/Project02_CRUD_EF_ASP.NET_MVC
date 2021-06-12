using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project03_CRUD_With_ASP.NET_MVC.Models;
using Project03_CRUD_With_ASP.NET_MVC.Database;

namespace Project03_CRUD_With_ASP.NET_MVC.Controllers
{
    public class TodoItemsController : Controller
    {
        private readonly ILogger<TodoItemsController> _logger;
        private readonly AppDbContext _db;

        public TodoItemsController(ILogger<TodoItemsController> logger, AppDbContext db)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["items"] = _db.TodoItems.ToArray();
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, bool What, bool When, bool Where, bool Why, bool How)
        {
            _db.TodoItems.Add(new TodoItem(name, What, Why, When, Where, How));
            _db.SaveChanges();
            return Redirect("/TodoItems/Index");
        }

        public IActionResult Read(int? Id)
        {
            if (Id != null)
                ViewData["item"] = _db.TodoItems.Where<TodoItem>(item => item.Id == Id);
            return View();
        }

        public IActionResult Edit(int? Id)
        {
            if (Id != null)
                ViewData["item"] = _db.TodoItems.Where<TodoItem>(item => item.Id == Id);
            return View();
        }

        [HttpPost]
        public IActionResult Update([Bind] TodoItem item)
        {
            _db.Update(item);
            _db.SaveChanges();
            return Redirect("/TodoItems/Index");
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null && _db.TodoItems.Where<TodoItem>(item => item.Id == Id).Any())
            {
                _db.TodoItems.Remove(_db.TodoItems.Where<TodoItem>(item => item.Id == Id).First<TodoItem>());
                _db.SaveChanges();
            }
            return Redirect("/TodoItems/Index");
        }
    }
}
