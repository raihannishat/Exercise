using System;
using System.Collections.Generic;
using System.Text;

namespace Code_3_7_4
{
    public class variableScope
    {
        private int x = 0; 
        private int y = 0;
        
        public void print()
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            int q = 6;

            if (q < 5)  // block 1 (outer block)
            {
                int n = 9;

                if (n == 9) // block 2 (inner block)
                {
                    n = 0;
                }
            }

            n = 0; // n is out of Scope
        }
    }
}
