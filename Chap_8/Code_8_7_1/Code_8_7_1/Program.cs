using System;
using System.Collections.Generic;
using System.Linq;

namespace Code_8_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericsStack<string> stack = new GenericsStack<string>();
            stack.push("Bangladesh");
            stack.push("India");
            stack.push("Pakistan");
            stack.push("Nepal");
            stack.push("Bhutan");
            stack.push("Myanmar");
            stack.print();
        }
    }
}
