using System;

namespace Code_3_8_1_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, spc;

            for (i = 5; i >= 1; i--)
            {
                for (spc = i; spc < 5; spc++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    if ((i == 4 && j == 2) || (i == 4 && j == 3) || (i == 3 && j == 2)) 
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }

                Console.WriteLine();
            }
        }    
    }
}
