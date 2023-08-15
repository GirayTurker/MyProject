using System.Web.Mvc;
using Movies_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies_MVC.Controllers
{
    public class MoviesController: Controller
    {
        //GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
           return View(movie);
           //return Content("Hello World");
           //return HttpNotFound();
           //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" }); // Shows on Browser as http://localhost:5000/?page=1&sortBy=name
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //Fixed this section. HasValue function is printing only value 1 for pageIndex
            const int a = 1;
            if (pageIndex.Equals(null))
            {
                pageIndex = a;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex,sortBy));
        }
    }
}