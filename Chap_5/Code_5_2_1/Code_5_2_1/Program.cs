using System;

namespace Code_5_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // A 12x8 grid, in [row][col]
            int[,] myArray = new int[12, 8];
            int numRows = myArray.GetLength(0); // 12
            int numCols = myArray.GetLength(1); // 8

            //Fill the array
            for (int row = 0; row < numRows; ++row)
            {
                for (int col = 0; col < numCols; ++col)
                {
                    myArray[row, col] = row * numCols + col + 1;
                }
            }

            // Print the array

            for (int row = 0; row < numRows; ++row)
            {
                for (int col = 0; col < numCols; ++col)
                {
                    Console.Write("{0,3}", myArray[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
