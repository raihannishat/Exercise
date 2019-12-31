using System;

namespace Code_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] ara_2d = new[] {
                new[] { 1, 2, 3, 4 },
                new[] { 5, 6, 7, 8 },
                new[] { 9, 10, 11, 12 },
                new[] { 13, 14, 15, 16 },
            };

            foreach (var item in ara_2d)
            {
                foreach (var value in item)
                {
                    Console.Write("{0, 4}", value);
                }
                Console.WriteLine();
            }
        }
    }
}
