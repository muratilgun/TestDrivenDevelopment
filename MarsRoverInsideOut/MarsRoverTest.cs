using NUnit.Framework;

namespace MarsRoverInsideOut
{
    [TestFixture]
    public class MarsRoverTest
    {
        [TestCase("N","E")]
        [TestCase("E","S")]
        [TestCase("S","W")]
        [TestCase("W","N")]
        public void TurnsRightClockwise(string startsFacing, string endsFacing)
        {
            Rover rover = new Rover(startsFacing, new[] { 0, 0 });
            rover.Right();
            Assert.AreEqual(endsFacing,rover.Facing);
        }
        
        [TestCase("N","W")]
        [TestCase("W","S")]
        [TestCase("S","E")]
        [TestCase("E","N")]
        public void TurnsLeftAntiClockwise(string startsFacing, string endsFacing)
        {
            Rover rover = new Rover(startsFacing, new[] { 0, 0 });
            rover.Left();
            Assert.AreEqual(endsFacing,rover.Facing);
        }
        [TestCase("N",new[]{5,5},new[]{5,6})]
        [TestCase("E",new[]{5,5},new[]{6,5})]
        [TestCase("S",new[]{5,5},new[]{5,4})]
        [TestCase("W",new[]{5,5},new[]{4,5})]
        public void MovesForwardInDirectionFacing(string facing, int[] startPosition, int[] endPosition)
        {
            Rover rover = new Rover(facing, startPosition);
            rover.Forward();
            Assert.AreEqual(endPosition,rover.Position);
        }
        
        
        
        [TestCase('R',"Right")]
        [TestCase('L',"Left")]
        [TestCase('F',"Forward")]
        [TestCase('B',"Back")]
        public void FindsActionForInstruction(char instruction, string methodName)
        {
            Assert.AreEqual(methodName,new Rover(null,null).FindAction(instruction).Method.Name);
        }

        [Test]
        public void ExecutesSequenceOfInstructions()
        {
            Rover rover = new Rover("N",new []{7,5});
            rover.Go("RFF");
            Assert.AreEqual("W",rover.Facing);
            Assert.AreEqual(new []{7,5},rover.Position);
        }
    }
}