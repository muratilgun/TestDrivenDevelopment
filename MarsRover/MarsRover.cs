using System.Linq;

namespace MarsRover
{
    public class MarsRover
    {
        public MarsRover(string facing, int x, int y)
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
                    // if (Right()) return;
                    Right();
                }
                if (instruction == 'L')
                {
                    // if (Left()) return;
                    Left();
                }
                
                if (instruction == 'F')
                {
                    Forward();
                }

                if (instruction == 'B')
                {
                    Back();
                }
            });
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

        private void Right()
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
    }
}