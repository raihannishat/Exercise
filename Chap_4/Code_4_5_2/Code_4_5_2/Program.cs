using System;

namespace Code_4_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number time table: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
            }
        }
    }
}
