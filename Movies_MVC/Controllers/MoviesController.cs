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
        }
    }
}