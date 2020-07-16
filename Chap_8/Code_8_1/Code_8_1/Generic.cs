using System;
using System.Collections.Generic;
using System.Text;

namespace Code_8_1
{
    public class Generic<T>
    {
        private T obj;

        public Generic(T obj)
        {
            this.obj = obj;
        }

        public T getObj()
        {
            return obj;
        }

        public void showType()
        {
            Console.WriteLine($"Type od T is: {obj.GetType().Name}");
        }
    }
}
