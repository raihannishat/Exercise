using System;

namespace Code_4_5_1_d
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j < ((8 - i) * 2) + 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
    }
}
