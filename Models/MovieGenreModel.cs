using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models{
    public class MovieGenreModel{
        public List<Movie> Movies;
        public SelectList Genres;
        public string MovieGenre {get;set;}
        public string SearchString {get;set;}
    }
}