using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compound.Data;
using Compound.Models;

namespace Compound.Controllers
{
    public class StaffController : Controller
    {
        

        private readonly AppDbContext _context;

        public StaffController(AppDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            var Staff = _context.Staff.ToList();
            var Villa = _context.Villa.ToList();
            var Events = _context.Events.ToList();
            var Services = _context.Services.ToList();

            ViewData["Staff"] = Staff;
            ViewData["Villa"] = Villa;
            ViewData["Events"] = Events;
            ViewData["Services"] = Services;
            return View();
        }


        public IActionResult Details(int? id)
        {
            var Staff = _context.Staff.ToList();
            var Villa = _context.Villa.ToList();
            var Events = _context.Events.ToList();
            var Services = _context.Services.ToList();
            var Users = _context.Users.ToList();

            StaffModel staff = Staff.Find(match: model => model.Staff_Id == id);

            if (staff == null)
            {
                return Content("No Staff with that id");
            }
            else
            {
                ViewData["Staff"] = Staff;
                ViewData["Villa"] = Villa;
                ViewData["Events"] = Events;
                ViewData["Services"] = Services;
                ViewData["Users"] = Users;
                ViewData["StaffList"] = staff;
                return View();
            }

           
          
        }
    }
}
