﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eivom.Models
{
    public class StockBetweenOneAndTwenty : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.GenreId == Genre.Unknown ||
                 movie.GenreId == Genre.Action)
                return ValidationResult.Success;

            var numberOfStock = movie.NumberInStock;


            return (numberOfStock > 0 && numberOfStock <= 20)
                ? ValidationResult.Success
                : new ValidationResult("The field Number in Stock must be between 1 and 20");
        }

    }
}