using System;

namespace Code_4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfRows = 9;
            int rowCount = 1;

            for (int i = noOfRows; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= rowCount; j++)
                {
                    Console.Write("{0} ", rowCount);
                }
                Console.WriteLine();
                rowCount++;
            }
        }
    }
}
