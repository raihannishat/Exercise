using System;

namespace Code_3_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 1;
            int value2 = 2;

            if (value1 == value2)
            {
                Console.WriteLine("value1 == value2");
            }

            if (value1 != value2)
            {
                Console.WriteLine("value1 != value2");
            }

            if (value1 > value2)
            {
                Console.WriteLine("value1 > value2");
            }

            if (value1 < value2)
            {
                Console.WriteLine("value1 < value2");
            }

            if (value1 <= value2)
            {
                Console.WriteLine("value1 <= value2");
            }
        }
    }
}
