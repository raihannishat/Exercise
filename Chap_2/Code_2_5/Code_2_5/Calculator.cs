using System;
using System.Collections.Generic;
using System.Text;

namespace Code_2_5
{
    public class Calculator
    {
        public int performAddition(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int performAddition(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            return result;
        }

        public float performAddition(float a, float b)
        {
            float result = a + b;
            return result;
        }
    }
}
