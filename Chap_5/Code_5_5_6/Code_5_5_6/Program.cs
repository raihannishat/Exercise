using System;

namespace Code_5_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number(k): ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: {0}", Find(array, k));
        }

        public static int Find(int[] x, int n)
        {
            int count = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == n)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
