using System;

namespace Code_5_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -45, 1, 8, 4, 5, 4, 5, 105 };

            Console.WriteLine("Index\tValue");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", i, a[i]);
            }
        }
    }
}
