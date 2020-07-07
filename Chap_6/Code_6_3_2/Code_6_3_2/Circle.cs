using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_3_2
{
    public class Circle
    {
        public double radius { get; set; }
        public string color { get; set; }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public Circle()
        {
            radius = 1.0;
            color = "RED";
        }

        public virtual double getArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
