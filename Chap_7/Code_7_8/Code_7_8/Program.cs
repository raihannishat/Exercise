using System;

namespace Code_7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter another integer: ");
            int b = int.Parse(Console.ReadLine());

            int? result = divide(a, b);

            Console.WriteLine($"Result: {a}/{b} = {result}");
        }

        static int? divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(Environment.StackTrace);
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
