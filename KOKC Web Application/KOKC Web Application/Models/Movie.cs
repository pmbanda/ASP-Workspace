using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace KOKC_Web_Application.Models
{
    /// <summary>
    /// class to encapsulate the Movie Data
    /// </summary>
    public class Movie
    {
        // Movie fields 
        public int ID { get; set; }

        [StringLength(60 , MinimumLength = 3, ErrorMessage = "Minimum length 3 characters")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [StringLength(30, ErrorMessage = "length NOT more than 30 characters ")]
        public string Genre { get; set; }
        
        [Range(1, 10)]
        public int Rating { get; set; }

        [Range(1, 1000)]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Please enter the Movie Price")]
        public decimal Price { get; set; }

    }
    /// <summary>
    /// database class to connect to the movie properties
    /// </summary>
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }

}