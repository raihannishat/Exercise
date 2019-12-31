using System;

namespace Code_5_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            stack.push(6);
            stack.push(7);
            stack.push(8);
            stack.pop();
            stack.pop();
            stack.pop();
            stack.print();
        }
    }
}
