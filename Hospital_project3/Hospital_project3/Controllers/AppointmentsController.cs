using Hospital_project3.Data;
using Hospital_project3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_project3.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly AppDbContext _db;

        public AppointmentsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Appointments = _db.Appointments.ToList();
            var Patients = _db.Patients.ToList();
            var Doctors = _db.Physicians.ToList();

            ViewData["Appointments"] = Appointments;
            ViewData["Patients"] = Patients;
            ViewData["Doctors"] = Doctors;
            return View();
        }
        public IActionResult Create(int? Id)
        {
            ViewBag.Physician = Id;
            return View();
        }

        //post
        [HttpPost]
        public IActionResult Create([Bind("ID", "Date_Time", "PatientId", "PhysicianId")] AppointmentModel Appointment)
        {
            if (ModelState.IsValid)
            {
                _db.Appointments.Add(Appointment);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            var Appointment = _db.Appointments.ToList().Find(p => p.ID == id);
            if (id == null && Appointment == null)
            {
                return View("_NotFound");
            }
            ViewData["Appointment"] = Appointment;
            return View();
        }

        //post
        [HttpPost]
        public IActionResult Edit([Bind("ID", "Date_Time", "PatientId", "PhysicianId")] AppointmentModel Appointment)
        {
            _db.Appointments.Update(Appointment);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Appointment = _db.Appointments.ToList().Find(p => p.ID == id);
            if (id == null && Appointment == null)
            {
                return View("_NotFound");
            }
            _db.Appointments.Remove(Appointment);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
