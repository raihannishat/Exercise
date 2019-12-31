using System;

namespace Code_5_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = Max(array);
            int min = Min(array);

            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Min: {0}", min);
        }

        public static int Max(int[] x)
        {
            int max = x[0];

            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
            }

            return max;
        }

        public static int Min(int[] x)
        {
            int min = x[0];

            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                }
            }

            return min;
        }
    }
}
