using NUnit.Framework;

namespace MarsRoverDuplication.Test
{
    public class MarsRoverTest
    {
        [Test]
        public void TurnsRightFromNorthToEast()
        {
            Rover rover = new Rover("N");
            rover.Go("R");
            Assert.AreEqual("E",rover.Facing);
        }

        [Test]
        public void TurnsRightEastToSouth()
        {
            Rover rover = new Rover("E");
            rover.Go("R");
            Assert.AreEqual("S",rover.Facing);  
        }
    }
}