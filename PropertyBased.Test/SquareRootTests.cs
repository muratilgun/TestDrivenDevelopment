using NUnit.Framework;

namespace PropertyBased.Test
{
    [TestFixture]
    public class SquareRootTests
    {
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(4,2)]
        [TestCase(9,3)]
        [TestCase(16,4)]
        [TestCase(0.25,0.5)]
        public void SquareRootOf(double number,double root)
        {
            Assert.AreEqual(root,new Maths().Sqrt(number));
        }
    }
}