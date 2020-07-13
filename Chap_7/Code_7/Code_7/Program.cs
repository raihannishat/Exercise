using System;

namespace Code_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;

            int result = 0;

            try
            {
                result = divide(a, b);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"You can't divide {a} by {b}");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Result: {result}");
        }

        static int divide(int a, int b)
        {
            return a / b;
        }
    }
}
