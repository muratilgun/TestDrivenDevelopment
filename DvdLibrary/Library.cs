using System.Collections.Generic;

namespace DvdLibrary
{
    public class Library
    {
        private List<Movie> _movies = new List<Movie>();
        public List<Movie> Catalogue => _movies;

        public void Donate(Movie movie)
        {
            _movies.Add(movie);
            movie.Copies++;
        }
    }
}