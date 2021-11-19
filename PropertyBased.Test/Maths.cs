using System;

namespace PropertyBased.Test
{
    public class Maths
    {
        public double Sqrt(double number)
        {
            double root = number / 2;
            double last = 0;
            while (Math.Abs(root - last) >  0)
            {
                last = root;
                root = (root + (number / root)) / 2;
            }

            return root;
        }
    }
}