using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VidlyRazorPage.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        // text box
        public string Name { get; set; }

        // text area
        public string Description { get; set; }

        // radio button
        public int Rating  { get; set; }

        // checkbox 
        public bool IsInTheatre { get; set; }

        //[ForeignKey ("GenreId")]
        // dropdown list
        public int GenreId { get; set; }

        // When eager loading using ".include", e.g. _context.Movies.Include(c => c.Genre),
        // only the single name of the genre will be stored in this property
        public Genre Genre { get; set; }

    }
}