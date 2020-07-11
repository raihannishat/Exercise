using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_3
{
    public class B : A
    {
        public B(int aValue) : base(aValue)
        {
            Console.WriteLine("inside sub class");
        }
    }
}
