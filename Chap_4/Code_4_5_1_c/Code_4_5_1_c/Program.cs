using System;

namespace Code_4_5_1_c
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 8; i > 0; i--)
            {
                for (int j = 0; j < (8 - i) * 2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
    }
}
