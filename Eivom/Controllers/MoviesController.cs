using Eivom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eivom.Models.ViewModels;

namespace Eivom.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" }, 
                new Customer {Name = "Customer 2" }, 
                new Customer {Name = "Customer 3" }

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            
            return View(viewModel);
           
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        
        //////movies
        ////public ActionResult Index(int? pageIndex, string sortBy)
        ////{
        ////    if (!pageIndex.HasValue)
        ////    {
        ////        pageIndex = 1;
        ////    }
        ////    if (String.IsNullOrWhiteSpace(sortBy))
        ////    {
        ////        sortBy = "Name";
        ////    }

        ////    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        ////}
        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
               
    }
}