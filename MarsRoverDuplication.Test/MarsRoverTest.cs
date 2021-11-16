using NUnit.Framework;

namespace MarsRoverDuplication.Test
{
    public class MarsRoverTest
    {
        [TestCase("N","E")]
        [TestCase("E","S")]
        [TestCase("S","W")]
        [TestCase("W","N")]
        public void TurnsRightsClockwise(string startsFacing, string endsFacing)
        {
            Rover rover = new Rover(startsFacing);
            rover.Go("R");
            Assert.AreEqual(endsFacing,rover.Facing);
        }

        [Test]
        public void TurnsRightEastToSouth()
        {
            Rover rover = new Rover("E");
            rover.Go("R");
            Assert.AreEqual("S",rover.Facing);  
        }

        [Test]
        public void TurnsRightSouthToWest()
        {
            Rover rover= new Rover("S");
            rover.Go("R");
            Assert.AreEqual("W", rover.Facing);
        }
    }
}