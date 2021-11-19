using System.Collections.Generic;
using Moq;
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
            Library library = new Library(info, new Mock<IMailServer>().Object);
            library.Donate("tt0000");
            Assert.True(library.Contains(title,year));
        }

        [Test]
        public void SendNewMovieEmailToAllMembers()
        {
            var mailServer = new Mock<IMailServer>();
            string title = "The Abyss";
            int year = 1989;
            Library library = new Library(new StubMovieInfo(title,year), mailServer.Object);
            library.Donate("tt0000");
            mailServer.Verify(m => m.Send("New Movie", "All Members", new string[]{title, year.ToString()}));
        }
    }

    public interface IMailServer
    {
        void Send(string template, string distributionList, string[] args);
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
        private readonly IMailServer _mailServer;
        private List<Movie> _catalogue = new List<Movie>();

        public Library(IMovieInfo info, IMailServer mailServer)
        {
            _info = info;
            _mailServer = mailServer;
        }

        public bool Contains(string title, int year)
        {
            return _catalogue.Exists((movie => movie.Title == title && movie.Year == year));
        }

        public void Donate(string imdbId)
        {
            Movie movie = _info.GetMovie(imdbId);
            _catalogue.Add(movie);
            _mailServer.Send("New Movie","All Members",new []{movie.Title,movie.Year.ToString()});
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