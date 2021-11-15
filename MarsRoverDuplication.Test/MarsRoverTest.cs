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

    }

    public class Rover
    {
        public Rover(string facing)
        {

        }

        public object Facing => "E";

        public void Go(string instructions)
        {
        }
    }
    
}