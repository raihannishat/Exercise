using System;

namespace Code_5_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] ara = new int[10];

            for (int i = 0; i < ara.Length; i++)
            {
                ara[i] = rnd.Next(100);
            }

            Console.Write("Array: ");
            Array.ForEach(ara, x => Console.Write("{0} ", x));

            Sort(ara);

            Console.Write("\nSorted array: ");
            Array.ForEach(ara, x => Console.Write("{0} ", x));
            Console.WriteLine("\nMedian of array: {0}", Median(ara, ara.Length));
        }

        public static int[] Sort(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[j] < x[i])
                    {
                        int temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }

            return x;
        }

        public static double Median(int[] x, int n)
        {
            Array.Sort(x);

            if (n % 2 != 0)
            {
                return x[n / 2];
            }

            return (x[(n - 1) / 2] + x[n / 2]) / 2.0;
        }
    }
}
