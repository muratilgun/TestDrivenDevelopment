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

            Facing = "W";
        }
    }
}