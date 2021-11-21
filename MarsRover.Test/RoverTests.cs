using NUnit.Framework;

namespace MarsRover.Test
{
    public class RoverTests
    {
        [Test]
        public void ExecutesSequenceOfInstructions()
        {
            MarsRover marsRover = new MarsRover("N", 5, 5);
            marsRover.Go("RFF");
            Assert.AreEqual(new[] {7,5}, marsRover.Position);
        } 
    }
}