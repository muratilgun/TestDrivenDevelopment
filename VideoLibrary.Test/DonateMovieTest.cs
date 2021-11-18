using System.Collections.Generic;
using NUnit.Framework;

namespace VideoLibrary.Test
{
    [TestFixture]
    public class DonateMovieTest
    {
        [Test]
        public void MovieAddedToLibrary()
        {
            string title = "The Abyss";
            int year = 1989;
            IMovieInfo info = new StubMovieInfo(title, year);
            Library library = new Library(info);
            library.Donate("tt0000");
            Assert.True(library.Contains(title,year));
        }
    }

    public class StubMovieInfo : IMovieInfo
    {
        private readonly string _title;
        private readonly int _year;

        public StubMovieInfo(string title, int year)
        {
            _title = title;
            _year = year;
        }

        public Movie GetMovie(string imdbId)
        {
            return new Movie(_title, _year);
        }
    }

    public interface IMovieInfo
    {
        Movie GetMovie(string imdbId);
    }

    public class Library
    {
        private readonly IMovieInfo _info;
        private List<Movie> _catalogue = new List<Movie>();

        public Library(IMovieInfo info)
        {
            _info = info;
        }

        public bool Contains(string title, int year)
        {
            return _catalogue.Exists((movie => movie.Title == title && movie.Year == year));
        }

        public void Donate(string imdbId)
        {
            _catalogue.Add(_info.GetMovie(imdbId));
        }
    }

    public class Movie
    {
        public string Title { get; }
        public int Year { get; }

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
    }
}