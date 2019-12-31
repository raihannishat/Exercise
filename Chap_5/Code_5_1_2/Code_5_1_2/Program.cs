using System;

namespace Code_5_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ARRAY_LENGTH = 10;
            int[] a = new int[ARRAY_LENGTH];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = fib(i);
            }

            Console.WriteLine("Index\tValue");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", i, a[i]);
            }
        }

        public static int fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
    }
}
