using System;

namespace MarsRoverDuplication.Test
{
    public class Rover
    {
        public Rover(string facing)
        {
            Facing = facing;
        }

        public string Facing { get; private set; }

        public void Go(string instructions)
        {
            string[] compass = { "N", "E", "S", "W" };
            int currentFacing = Array.IndexOf(compass,Facing);
            Facing = compass[(currentFacing + 1)% 4];
            // if (Facing == "N")
            // {
            //     Facing = "E";
            //     return;
            // }
            //
            // if (Facing == "E")
            // {
            //     Facing = "S";
            //     return;
            // }
            //
            // Facing = "W";
        }
    }
}