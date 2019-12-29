using System;

namespace Code_4_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string result;

            if (n % 2 == 0)
            {
                result = "even";
            }
            else
            {
                result = "odd";
            }

            Console.WriteLine("The number is {0}", result);
        }
    }
}
