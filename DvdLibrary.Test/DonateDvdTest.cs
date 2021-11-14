using NUnit.Framework;

namespace DvdLibrary
{
    public class DonateDvdTest
    {
        [Test]
        public void DonateDvd()
        {
            Library library = new Library();
            Movie movie = new Movie();
            library.Donate(movie);
            Assert.True(library.ContainsMovie( movie));
            Assert.AreEqual(1,movie.Copies);
        }


    }
}