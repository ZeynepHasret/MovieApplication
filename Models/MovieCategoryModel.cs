﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieCategoryModel
    {
        public Movie  Movie { get; set; }
        public List<Movie> Movies { get; set; }
       public List<Category> Categories { get; set; }


    }
}
