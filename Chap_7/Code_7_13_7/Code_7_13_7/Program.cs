using System;

namespace Code_7_13_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your amount: ");
            long amount = long.Parse(Console.ReadLine());

            checked
            {
                if (amount < 0)
                {
                    throw new NegativeNumberException("This is negative number");
                }
            }
        }
    }
}
