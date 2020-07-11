using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_1
{
    public abstract class Animal
    {
        private int legs;

        public Animal(int legs)
        {
            this.legs = legs;
        }

        public void sleep()
        {
            string name = GetType().Name;
            Console.WriteLine($"{name} sleeping...Don't disturb!");
        }
    }
}
