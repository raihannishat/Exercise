using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_3_2
{
    public class Cylinder : Circle
    {
        public double height { get; set; }

        public Cylinder()
        {
            height = 1.0;
        }

        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }

        public override double getArea()
        {
            double area = 2 * Math.PI * radius * height + 2 * base.getArea();

            return area;
        }
    }
}
