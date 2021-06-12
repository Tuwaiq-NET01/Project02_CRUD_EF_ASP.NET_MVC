using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tuwaiq_Student_Life.Data;
using Tuwaiq_Student_Life.Models;

namespace Tuwaiq_Student_Life.Controllers
{
    
    public class SessionController : Controller
    {
        private readonly AppDBContext _db;

        public SessionController(AppDBContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var Sessions = _db.Sessions.ToList();
            var Instructors = _db.Instructors.ToList();
            ViewData["Sessions"] = Sessions;
            ViewData["Instructors"] = Instructors;
            return View();
        }


        //GET - /session/create
        public IActionResult Create(int? instructor_id)
        {
            Debug.WriteLine("the id " + instructor_id);
            ViewData["SessionInstructorId"] = instructor_id;
            return View();
        }

        //POST - /session/create
        [HttpPost]
        public IActionResult Create([Bind("InstructorId", "SessionTime", "Duration", "Location")] SessionModel session
            )
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine("session id   "+ session.InstructorId);
                //session.InstructorId = instructor_id;
                _db.Sessions.Add(session);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            Debug.WriteLine("outside if session id   " + session.InstructorId);

            return RedirectToAction("Index");
        }

        //GEt - /session/edit/id
        public IActionResult Edit(int? id)
        {
            var Session = _db.Sessions.ToList().Find(s => s.Id == id);
            if (id == null || Session == null)
            {
                return View("_NotFound");
            }
            ViewData["Session"] = Session;
            return View();
        }

        //POST - /session/edit/id
        [HttpPost]
        public IActionResult Edit([Bind("Id", "InstructorId", "SessionTime", "Duration", "Location")] SessionModel session)
        {
            Debug.WriteLine("duration  "+session.Duration);
            Debug.WriteLine("Id  " + session.Id);
            Debug.WriteLine("Instructor Id  " + session.InstructorId);
            _db.Sessions.Update(session);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            SessionModel sessionToDelete = new SessionModel();
            sessionToDelete = _db.Sessions.Find(id);
            _db.Sessions.Remove(sessionToDelete);
            _db.SaveChanges();
            //Response.Redirect("/Session/Index");
            var Sessions = _db.Sessions.ToList();
            var Instructors = _db.Instructors.ToList();
            ViewData["Sessions"] = Sessions;
            ViewData["Instructors"] = Instructors;
            Response.Redirect("/Session");
            return View("Index");
        }
    }
}
