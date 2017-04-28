using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodApp.Models;
using Microsoft.AspNetCore.Identity;
using CodApp.ViewModels;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CodApp.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly CodAppDbContext _db;
        public NewsletterController(CodAppDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var newsletters = _db.Newsletters.ToList();
            return View(newsletters);
        }

        public IActionResult AddReader(Reader reader)
        {
            var newReader = new Reader { Name = reader.Name, Email = reader.Email };
            _db.Readers.Add(newReader);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            var currentNewsletter = _db.Newsletters
                .Include(m => m.Articles)
                .FirstOrDefault(m => m.Id == id);
            return View(currentNewsletter);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Newsletter newsletter)
        {
            var newNewsletter = new Newsletter { Title = newsletter.Title, Content = newsletter.Content };
            _db.Newsletters.Add(newNewsletter);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
