using System.Collections.Generic;

namespace DvdLibrary
{
    public class Library
    {
        private List<Movie> _movies = new List<Movie>();
        private List<Movie> Catalogue => _movies;

        public void Donate(Movie movie)
        {
            _movies.Add(movie);
            movie.AddCopy();
        }
        public  bool ContainsMovie( Movie movie)
        {
            return Catalogue.Contains(movie);
        }

    }
}