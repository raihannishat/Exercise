using System;
using System.Collections.Generic;
using System.Text;

namespace Code_5_5_1
{
    public class Stack
    {
        int n = 0;
        long[] ara = new long[1000000];
        public void push(int x)
        {
            ara[n] = x;
            n++;
        }

        public void pop()
        {
            n -= 1;
        }

        public void print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", ara[i]);
            }
        }
    }
}
