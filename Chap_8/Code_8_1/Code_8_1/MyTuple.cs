using System;
using System.Collections.Generic;
using System.Text;

namespace Code_8_1
{
    public class MyTuple<X, Y>
    {
        private X x;
        private Y y;

        public MyTuple(X x, Y y)
        {
            this.x = x;
            this.y = y;
        }

        public X GetX()
        {
            return x;
        }

        public Y GetY()
        {
            return y;
        }

        public void showType()
        {
            Console.WriteLine($"Type of T is: {x.GetType().Name} and value: {x}");
            Console.WriteLine($"Type of T is: {y.GetType().Name} and value: {y}");
        }
    }
}
