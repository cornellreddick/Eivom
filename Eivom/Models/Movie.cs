using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
u

namespace Eivom.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        [Display(ReleaseDate = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(DateAdded = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(NumberInStock = "Number In Stock")]
        public int NumberInStock { get; set; }
    }
}