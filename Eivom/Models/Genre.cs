using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eivom.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public readonly static byte Unknown = 0;
        public readonly static byte Action = 1;
    }
}