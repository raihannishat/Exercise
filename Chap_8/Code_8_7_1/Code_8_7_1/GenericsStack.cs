using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Code_8_7_1
{
    public class GenericsStack<T>
    {
        private IList<T> stack = new List<T>();

        public void push(T item)
        {
            stack.Insert(0, item);
        }

        public void pop()
        {
            stack.RemoveAt(0);
        }

        public void peek(int position)
        {
            Console.WriteLine(stack[position - 1]);
        }

        public void print()
        {
            foreach (var item in stack)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
