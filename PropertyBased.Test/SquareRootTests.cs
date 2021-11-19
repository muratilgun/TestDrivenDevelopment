using NUnit.Framework;

namespace PropertyBased.Test
{
    [TestFixture]
    public class SquareRootTests
    {
        [Test]
        public void RooOf0Is0()
        {
            Assert.AreEqual(0.0,new Maths().Sqrt(0.0));
        }

        [Test]
        public void RootOf1Is1()
        {
            Assert.AreEqual(1.0,new Maths().Sqrt(1.0));
        }
        [Test]
        public void RootOf4Is2()
        {
            Assert.AreEqual(2.0,new Maths().Sqrt(4.0));
        }
        [Test]
        public void RootOf9Is3()
        {
            Assert.AreEqual(3.0,new Maths().Sqrt(9.0));
        }
        [Test]
        public void RootOf25Is5()
        {
            Assert.AreEqual(5.0,new Maths().Sqrt(25.0));
        }
    }
}