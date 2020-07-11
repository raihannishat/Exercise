using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_2
{
    public class Lion : Animal
    {
        public Lion(int legs) : base(legs) 
        {

        }

        public override string getDiets()
        {
            return "Meat";
        }
    }
}
