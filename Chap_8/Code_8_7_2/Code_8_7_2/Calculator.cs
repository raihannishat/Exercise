using System;
using System.Collections.Generic;
using System.Text;

namespace Code_8_7_2
{
    public class Calculator<Type>
    {
        public Type add(Type t1, Type t2)
        {
            dynamic d1 = t1;
            dynamic d2 = t2;
            return d1 + d2;
        }

        public Type mul(Type t1, Type t2)
        {
            dynamic d1 = t1;
            dynamic d2 = t2;
            return d1 * d2;
        }

        public Type sub(Type t1, Type t2)
        {
            dynamic d1 = t1;
            dynamic d2 = t2;
            return d1 - d2;
        }

        public Type div(Type t1, Type t2)
        {
            dynamic d1 = t1;
            dynamic d2 = t2;
            return d1 / d2;
        }
    }
}
