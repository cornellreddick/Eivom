using Eivom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eivom.ViewModels;


namespace Eivom.Controllers
{
    public class MoviesController : Controller
    {
      public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Black Panther"},
                new Movie {Id = 2, Name = "AntMan and Wasp"}
            };
        }
    }
}