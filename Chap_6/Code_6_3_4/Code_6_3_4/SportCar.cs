using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_3_4
{
    public class SportCar : Car
    {
        public new int speed = 100;

        public void printSpeed()
        {
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Speed: {base.speed}");
        }
    }
}
