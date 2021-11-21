using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class MarsRover
    {
        private static readonly string[] AntiClockwise = new []{ "N", "W", "S", "E" };

        public MarsRover(string facing, int x, int y)
        {
            Position = new[] { x, y };
            Facing = facing;
        }

        public int[] Position { get; private set; }
        public string Facing { get; private set; }

        public void Go(string instructions)
        {
            // instructions.ToCharArray().ToList().ForEach((instruction) => { Execute(instruction); });
            instructions.ToCharArray().ToList().ForEach(Execute);
        }

        private void Execute(char instruction)
        {
            Dictionary<char, Action> commands = new Dictionary<char, Action>()
            {
                { 'R', Right },
                { 'L', Left },
                { 'F', Forward },
                { 'B', Back },
            };
            commands[instruction]();
        }

        private void Back()
        {
            if (Facing == "N")
            {
                Position = new[] { Position[0], Position[1] - 1 };
            }

            if (Facing == "E")
            {
                Position = new[] { Position[0] - 1, Position[1] };
            }

            if (Facing == "S")
            {
                Position = new[] { Position[0], Position[1] + 1 };
            }

            if (Facing == "W")
            {
                Position = new[] { Position[0] + 1, Position[1] };
            }
        }
        private void Forward()
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
        private void Left()
        {
            
            Turn(AntiClockwise);
        }
        private void Right()
        {
          Turn(new []{"N","E","S","W"});
        }
        private void Turn(string[] compass)
        {
            int current = Array.IndexOf(compass, Facing);
            Facing = compass[(current + 1) % 4];
        }
    }
}