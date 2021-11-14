using NUnit.Framework;

namespace DvdLibrary
{
    public class DonateDvdTest
    {
        private Library _library;
        private Movie _movie;
        [SetUp]
        public void SetUp()
        {
            _movie = new Movie();
            _library = new Library();
            _library.Donate(_movie);
        }
        [Test]
        public void DonateDvd()
        {
            Assert.True(_library.ContainsMovie( _movie));
            RentalCopyAddedToMovie();
        }
        [Test]
        public void RentalCopyAddedToMovie()
        {
            Assert.AreEqual(1, _movie.Copies);
        }
    }
}