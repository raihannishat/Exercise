﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_2
{
    public class Deer : Animal
    {
        public Deer(int legs) : base(legs)
        {

        }

        public override string getDiets()
        {
            return "Grass";
        }
    }
}
