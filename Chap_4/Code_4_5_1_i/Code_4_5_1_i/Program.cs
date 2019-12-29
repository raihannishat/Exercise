using System;

namespace Code_4_5_1_i
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (i == 1 || i == 7 || j == 1 || j == 7 || i == j || (i + j) == 8)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
