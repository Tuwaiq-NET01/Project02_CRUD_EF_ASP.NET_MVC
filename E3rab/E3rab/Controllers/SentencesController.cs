using System.Linq;
using E3rab.Models;
using Microsoft.AspNetCore.Mvc;

namespace E3rab.Controllers
{
    public class SentencesController : Controller
    {
          private readonly ArabicContext _db;

        public SentencesController(ArabicContext db)
        {
            _db = db;
        }
        // GET: /Sentences
        public IActionResult Index()
        {
            var Sentences = _db.Sentences.ToList();
            ViewData["Sentences"] = Sentences;
            return View();
        }

        // GET: /sentences/id
        public IActionResult Details(int? id)
        {
            var Sentence = _db.Sentences.ToList().Find(sentence => sentence.Id == id);
            if(id == null || Sentence == null)
            {
                return View("_NotFound");
            }
            ViewData["Sentence"] = Sentence;
            return View(Sentence);

        }
        
        public IActionResult Create()
        {
            
            return View();

        }
        
        //post - /Sentences/Create 

        [HttpPost]
        public IActionResult Create([Bind("Id","Sentence1" , "E3rab")] Sentence sentence) 
        {
            
            if (ModelState.IsValid)
            {
                _db.Sentences.Add(sentence);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(); 
        }

        public IActionResult Edit(int? id)
        {
            var sentence = _db.Sentences.ToList().Find(p => p.Id == id);

            if (id == null || sentence == null)
            {
                return View("_NotFound"); 
            }

            ViewData["Sentence"] = sentence; 
            
            return View(); 
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id", "Sentence1", "E3rab")]
            Sentence sentence)
        {

            _db.Sentences.Update(sentence);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        // Post 
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            var sentence = _db.Sentences.ToList().Find(p => p.Id == id);

            if (id == null || sentence == null)
            {
                return View("_NotFound");
            }

            _db.Sentences.Remove(sentence);
            _db.SaveChanges();
            return RedirectToAction("Index"); 
            
        }
    }
}