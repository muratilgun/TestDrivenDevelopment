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
            Assert.True(library.Catalogue.Contains(movie));
        }
    }
}