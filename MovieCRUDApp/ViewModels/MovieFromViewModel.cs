using MovieCRUDApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCRUDApp.ViewModels
{
    public class MovieFromViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(250)]
        public String Title { get; set; }

        public int Year { get; set; }
        [Range(1,10)]
        public Double Rate { get; set; }
        [Display(Name = "Select Poster")]
        public Byte[] Poster { get; set; }

        [StringLength(2500), Required]
        public String Storyline { get; set; }

        public IEnumerable<Genre> genres { get; set; }
        [Display(Name ="Genre")]
        public Byte GenreId { get; set; }
    }
}
