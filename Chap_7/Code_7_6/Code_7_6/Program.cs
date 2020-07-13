using System;

namespace Code_7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void calculator(int a, int b)
        {
            if (a < 0)
            {
                throw new ArgumentException("Argument a can not be negative");
            }

            if (b < 0)
            {
                throw new ArgumentException("Argument b can not be negative");
            }

            // do other stuff
        }
    }
}
