using NUnit.Framework;

namespace MarsRover.Test
{
    public class RoverTests
    {
        [Test]
        public void ExecutesSequenceOfInstructions()
        {
            Rover rover = new Rover("N", 5, 5);
            rover.Go("RFF");
            Assert.AreEqual(new[] {7,5}, rover.Position);
        } 
    }
}