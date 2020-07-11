using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_7_2
{
    public class AreaCalculator
    {
        public double getArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double getArea(int length, int width)
        {
            return 0.5 * width * length;
        }

        public double getArea(long bases, int height)
        {
            return bases * height;
        }

        public double getArea(double radius, double height)
        {
            return 2 * Math.PI * radius * (height + radius);
        }
    }
}
