using Hospital_project3.Data;
using Hospital_project3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_project3.Controllers
{
    public class PatientsController : Controller
    {
        private readonly AppDbContext _db;

        public PatientsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Patients = _db.Patients.ToList();
            ViewData["Patients"] = Patients;
            return View();
        }

        //post
        [HttpPost]
        public IActionResult Create([Bind("NationalID", " Name", "Address", "Gender")] PatientModel Patient)
        {
            if (ModelState.IsValid)
            {
                _db.Patients.Add(Patient);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var Patient = _db.Patients.ToList().Find(p => p.NationalID == id);
            if (id == null && Patient == null)
            {
                return View("_NotFound");
            }
            ViewData["Patient"] = Patient;
            return View();
        }

        //post
        [HttpPost]
        public IActionResult Edit([Bind("NationalID", " Name", "Address", "Gender")] PatientModel Patient)
        {
            _db.Patients.Update(Patient);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var Patient = _db.Patients.ToList().Find(p => p.NationalID == id);
            if (id == null && Patient == null)
            {
                return View("_NotFound");
            }
            _db.Patients.Remove(Patient);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
