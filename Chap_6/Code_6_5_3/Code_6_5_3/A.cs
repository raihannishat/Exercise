using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_3
{
    public abstract class A
    {
        int aValue;

        public A(int aValue)
        {
            this.aValue = aValue;
            Console.WriteLine("inside abstract class");
        }
    }
}
