using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_3_2
{
    public class AdvanceCalculator : Calculator
    {
        public override Int64 add(Int64 a, Int64 b)
        {
            if (a == null || b == null)
            {
                Console.WriteLine("Argument can't be null");
                return 0;
            }

            return a + b;
        }
    }
}
