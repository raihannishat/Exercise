using System;
using System.Collections.Generic;
using System.Text;

namespace Code_4_5_7
{
    public class SwitchTest
    {
        public void doCalculate()
        {
            int number = 1;

            var result = number switch
            {
                1 => "ONE",
                2 => "TWO",
                _ => "This the default output"
            };

            Console.WriteLine(result);
        }
    }
}
