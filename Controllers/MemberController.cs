using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project03.Models;

namespace Project03.Controllers
{
    public class MemberController : Controller
    {
        private readonly LibraryContext _db;

        public MemberController(LibraryContext context)
        {
            _db = context;
        }

        public IActionResult Member()
        {
            var members = _db.Members.ToList();

            ViewData["members"] = members;
            return View();
        }

        public IActionResult Details(int id)
        {
            var member = _db.Members.ToList().Find(P => P.Id == id);

            if (member == null)
            {
                return Content("ii");
            }

            ViewData["members"] = member;
            return View(member);
        }

        //Get - path: Member/Create
        public IActionResult Create()
        {
            return View();
        }

        //Post - path: Member/Create
        [HttpPost]
        public IActionResult Create([Bind("Name", "Address", "ExpiryDate")] Member member) // Bind with product model
        {
            if (ModelState.IsValid)// check the state of the model
            {
                _db.Members.Add(member);
                _db.SaveChanges();
                return RedirectToAction("Member");
            }
            return View(member);
        }

        //Update - path: Member/Edit
        public IActionResult Edit(int id)
        {
            var member = _db.Members.ToList().Find(p => p.Id == id);
            if (id == null || member == null)
            {
                return RedirectToAction("Member");
            }
            ViewData["members"] = member;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("Name", "Address", "ExpiryDate")] Member membr)
        {
            var Member = _db.Members.ToList().Find(p => p.Id == id);
            Member.Name = membr.Name;
            Member.Address = membr.Address;
            Member.ExpiryDate = membr.ExpiryDate;
            _db.Members.Update(Member);
            _db.SaveChanges();
            return RedirectToAction("Member");
        }

        //Delete - path: Member/Delete
        public IActionResult Delete(int id)
        {
            var member = _db.Members.FirstOrDefault(p => p.Id == id);
            _db.Members.Remove(member);
            _db.SaveChanges();
            return RedirectToAction("Member");
        }
    }
}
