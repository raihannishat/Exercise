using System;

namespace Code_4_5_1_e
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (j == 1 || i == 1 || j == 7 || i == 7)
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
