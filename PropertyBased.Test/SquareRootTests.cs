using System;
using NUnit.Framework;

namespace PropertyBased.Test
{
    [TestFixture]
    public class SquareRootTests
    {
        [Test]
        public void SquareRootOf([Random(0.0, 100.0, 100)] double number)
        {
            double root = new Maths().Sqrt(number);
            Assert.AreEqual(number, root * root, 1E-12);
        }
    }
}