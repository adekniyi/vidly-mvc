using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Mary William"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Customer = customer
            };
            return View(viewModel);
        }
    }
}