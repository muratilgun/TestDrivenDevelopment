using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoverInsideOut
{
    public class Rover
    {
        public Rover(string facing, int[] position)
        {
            Facing = facing;
            Position = position;
        }

        public string Facing { get; private set; }
        public int[] Position { get; private set; }
        private void Move(int[][] vectors)
        {
            int facing = Array.IndexOf(new[] { "N", "E", "S", "W" }, Facing);
            int[] vector = vectors[facing];
            Position[0] += vector[0];
            Position[1] += vector[1];
        }
        public Action FindAction(char instruction)
        {
            return new Dictionary<char, Action>()
            {
                {'R',Right},
                {'L',Left},
                {'F',Forward},
                {'B',Back}
            }[instruction];
        }

        public void Go(string instructions)
        {
            if (instructions == "R")
            {
                
                Right();
            }
            else
            {
                Left();

            }
        }
        public void Right()
        {
            Turn(new []{"N","E","S","W"});
        }
        public void Left()
        {
            Turn(new[] { "N", "W", "S", "E" });
        }

        private void Turn(string[] compass)
        {
            int current = Array.IndexOf(compass, Facing);
            Facing = compass[(current + 1) % 4];
        }

        public void Forward()
        {
            Move(new[]{new []{0,1},new []{1,0},new []{0,-1},new []{-1,0}});

        }
        public void Back()
        {         
            Move(new[]{new []{0,-1},new []{-1,0},new []{0,1},new []{1,0}});
        }
    }
}