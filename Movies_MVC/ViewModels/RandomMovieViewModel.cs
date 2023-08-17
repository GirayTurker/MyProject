using System.Collections.Generic;
using Movies_MVC.Models;

namespace Movies_MVC.ViewModels
{
    // Created for Domain Movie and Customers
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}