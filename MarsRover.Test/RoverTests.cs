using System.Linq;
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

    public class Rover
    {
        public Rover(string facing, int x, int y)
        {
            Position = new[] { x, y };
            Facing = facing;
        }

        public int[] Position { get; private set; }
        public string Facing { get; private set; }

        public void Go(string instructions)
        {
            instructions.ToCharArray().ToList().ForEach((instruction) =>
            {
                if (instruction == 'R')
                {
                    if (Facing == "N")
                    {
                        Facing = "E";
                        return;
                    }
                    if (Facing == "E")
                    {
                        Facing = "S";
                        return;
                    }
                    if (Facing == "S")
                    {
                        Facing = "W";
                        return;
                    }
                    Facing = "N";
                }
                if (instruction == 'L')
                {
                    if (Facing == "N")
                    {
                        Facing = "S";
                        return;
                    }
                    if (Facing == "W")
                    {
                        Facing = "S";
                        return;
                    }
                    if (Facing == "S")
                    {
                        Facing = "E";
                        return;
                    }

                    Facing = "N";
                }
                if (instruction == 'F')
                {
                    if (Facing == "N")
                    {
                        Position = new[] { Position[0], Position[1] + 1 };
                    }

                    if (Facing == "E")
                    {
                        Position = new[] { Position[0] + 1, Position[1] };
                    }

                    if (Facing == "S")
                    {
                        Position = new[] { Position[0], Position[1] - 1 };
                    }

                    if (Facing == "W")
                    {
                        Position = new[] { Position[0] - 1, Position[1] };
                    }
                }
            });
        }
    }
}