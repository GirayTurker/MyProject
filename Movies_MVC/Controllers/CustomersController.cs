using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Movies_MVC.Models;
using Movies_MVC.ViewModels;

namespace Movies_MVC.Controllers
{
    public class CustomersController:Controller
    {
        //Customer page View
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        
        //Customer page List of Customers
        private static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer{Id = 2, Name = "Mary Williams"}
            };
        }
        
        //Customer/Details/# page 
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}