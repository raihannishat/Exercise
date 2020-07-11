using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_4
{
    public class Milk : Liquid
    {
        public override void swirl(bool clockwise)
        {
            Console.WriteLine("Swirling Milk");
        }
    }
}
