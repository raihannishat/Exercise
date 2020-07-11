using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_2
{
    public abstract class Animal
    {
        private int legs;

        public Animal(int legs)
        {
            this.legs = legs;
        }

        public abstract string getDiets();
    }
}
