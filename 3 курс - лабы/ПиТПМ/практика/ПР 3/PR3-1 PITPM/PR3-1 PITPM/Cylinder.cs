using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_1_PITPM
{
    public class Cylinder
    {
        public double CalculateVolume(double radius, double height)
        {
            if (radius < 0 || height < 0)
                throw new ArgumentException("Radius and height must be non-negative");

            return Math.PI * Math.Pow(radius, 2) * height; 
        }

    }
}
