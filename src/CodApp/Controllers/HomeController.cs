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
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private CodAppDbContext _db;
        public HomeController(CodAppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var currentArticle = _db.Articles.FirstOrDefault(m => m.Id == 1);
            Dictionary<string, Article> homeDictionary = new Dictionary<string, Article> { };
            homeDictionary["Banner"] = currentArticle;
            homeDictionary["Tagline"] = currentArticle;
            homeDictionary["Banner2"] = currentArticle;
            homeDictionary["Banner3"] = currentArticle;
            homeDictionary["Blurb1"] = currentArticle;
            homeDictionary["Blurb2"] = currentArticle;
            homeDictionary["Blurb3"] = currentArticle;
            homeDictionary["Blurb4"] = currentArticle;
            return View(homeDictionary);
        }
    }
}
