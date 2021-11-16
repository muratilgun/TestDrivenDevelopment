using NUnit.Framework;

namespace MarsRoverDuplication.Test
{
    public class MarsRoverTest
    {
        [TestCase("R","N","E")]
        [TestCase("R","E","S")]
        [TestCase("R","S","W")]
        [TestCase("R","W","N")]
        
        public void TurnsRightsClockwise(string direction, string startsFacing, string endsFacing)
        {
            Rover rover = new Rover(startsFacing);
            rover.Go(direction);
            Assert.AreEqual(endsFacing,rover.Facing);
        }

        [TestCase("N","E")]
        [TestCase("E","S")]
        [TestCase("S","W")]
        [TestCase("W","N")]
        
        public void TurnsLeftAntiClockwise(string startsFacing, string endsFacing)
        {
            Rover rover = new Rover(startsFacing);
            rover.Go("L");
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