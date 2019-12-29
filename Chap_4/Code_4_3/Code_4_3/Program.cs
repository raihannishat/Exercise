using System;

namespace Code_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("The number is {0}", i);
                if (i == 7)
                {
                    break;
                }
            }
        }
    }
}
