using System;

namespace Code_5_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your size: ");
            ulong size = ulong.Parse(Console.ReadLine());

            ulong[] ara = new ulong[size];

            for (ulong i = 0; i < size; i++)
            {
                ara[i] = fib(i);
            }

            Console.WriteLine("Index\tValue");

            for (ulong i = 0; i < size; i++)
            {
                Console.WriteLine("{0}\t{1}", i, ara[i]);
            }
        }

        public static ulong fib(ulong x)
        {
            if (x <= 1)
            {
                return x;
            }
            else
            {
                return fib(x - 1) + fib(x - 2);
            }
        }
    }
}
