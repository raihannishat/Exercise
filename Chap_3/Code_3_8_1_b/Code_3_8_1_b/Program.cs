using System;

namespace Code_3_8_1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //Console.Write("[{0},{1}] ", i, j);

                    if (i == 0 || i == 4 || j == 0 || j == 4)
                    {
                        Console.Write("* ");
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
