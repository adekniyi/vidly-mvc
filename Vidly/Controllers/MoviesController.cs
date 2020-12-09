using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random
        public ActionResult Random()
        {
            var movies = new Movie { Name = "Shark" };

            var customer = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                //Movie = movies,
                Customer = customer
            };
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
        }


        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
              new Movie { Name = "Shark", Id = 1 },
              new Movie {Name = "Wall e" , Id = 2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movies,
            };
            return View(viewModel);
        }


        // GET: Movies/Details/1
        [Route("Movies/Details/{id}")]
        public ActionResult Details(int id)
        {
            var movies = new List<Movie>
            {
              new Movie { Name = "Shark", Id = 1 },
              new Movie {Name = "Wall e" , Id = 2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movies,
            };

            foreach (var movie in viewModel.Movie)
            {
                if (movie.Id == id)
                {
                    return View(movie.Name);
                }
            }
            return HttpNotFound();
        }
        public ActionResult Edit(int id)
        {
            return Content($"id = {id}");
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{ year } / {month}");
        }
    }
}