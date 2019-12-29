using System;

namespace Code_4_5_1_a
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
    }
}
