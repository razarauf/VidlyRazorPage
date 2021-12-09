using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRazorPage.Models;

namespace VidlyRazorPage.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context = null;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            //base.Dispose(disposing);
            _context.Dispose();
        }

        // GET: Movie
        public ActionResult Index()
        {
            var movieViewModel = new MovieViewModel()
            {
                Genres = _context.Genres.ToList()
            };

            return View(movieViewModel);
        }

        [HttpPost]
        public ActionResult Index(Movie movie)
        {
            return View();
        }
    }
}