namespace DvdLibrary
{
    public class Movie
    {
        public double Copies { get; private set; }
        public void AddCopy()
        {
           Copies++;
        }
    }
}