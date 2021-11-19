using NUnit.Framework;

namespace PropertyBased.Test
{
    [TestFixture]
    public class SquareRootTests
    {
        [Test]
        public void SquareRootOf([Range(0,99)]double number)
        {
            double root = new Maths().Sqrt(number);
            Assert.AreEqual(number,root * root , 1E-12);
        }
    }
}