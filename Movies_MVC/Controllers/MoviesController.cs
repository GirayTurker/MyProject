using System.Web.Mvc;
using Movies_MVC.Models;
using System;
using System.Collections.Generic;
using Movies_MVC.ViewModels;


namespace Movies_MVC.Controllers
{
    public class MoviesController: Controller
    {
            //Movies page Index
            public ViewResult Index()
            {
                var movies = GetMovies();

                return View(movies);
            }
       
        //Movies page movies lists
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Fight Club" },
                new Movie { Id = 2, Name = "Matrix" }
            };
        }
        //GET: Movies/Random
        public ActionResult Random()
        {
           var movie = new Movie() { Name = "Shrek!" };

           var customers = new List<Customer>
           {
               new Customer { Name = "Customer 1" },
               new Customer { Name = "Customer 2" },
               new Customer { Name = "Customer 3" }
           };
           var viewModel = new RandomMovieViewModel
           {
               Movie = movie,
               Customers = customers
           };
           return View(viewModel);
           
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
            /*Fixed this section. HasValue function is printing only value 1 for pageIndex
            instead passing the override value for it*/
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
        
        /*Created for Custom route: http://localhost:5000/movies/released/int:year/int:month
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }
        */
        
        //Attribute Routing with constrains 
        //Route regex fixed. Ex: http://localhost:5000/movies/released/2015/12
        [Route("movies/released/{year:regex(^\\d{4}$)}/{month:range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}