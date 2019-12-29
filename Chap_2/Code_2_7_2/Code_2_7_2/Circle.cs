using System;
using System.Collections.Generic;
using System.Text;

namespace Code_2_7_2
{
    public class Circle
    {
        private int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public double getArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
