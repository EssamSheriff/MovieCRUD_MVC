using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCRUDApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required,MaxLength(250)]
        public String Title { get; set; }

        public int Year { get; set; }

        public Double Rate { get; set; }
        [Required]
        public Byte[] Poster { get; set; }

        [MaxLength(2500),Required]
        public String Storyline { get; set; }

        public Genre Genre { get; set; }

        public Byte GenreId { get; set; }
    }
}
