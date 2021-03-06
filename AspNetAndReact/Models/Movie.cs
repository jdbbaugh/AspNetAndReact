﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetAndReact.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public List<UserMovie> UserMovies { get; set; }
    }
}
