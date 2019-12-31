using System;

namespace Code_5_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] ara = new int[size];

            for (int i = 0; i < size; i++)
            {
                ara[i] = Convert.ToInt32(Console.ReadLine());
            }

            Sort(ara);

            Console.Write("Sorted array: ");
            Array.ForEach(ara, x => Console.Write("{0} ", x));

            Console.WriteLine();
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
    }
}
