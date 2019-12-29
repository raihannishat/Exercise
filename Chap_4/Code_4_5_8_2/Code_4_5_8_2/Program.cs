using System;

namespace Code_4_5_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double series = 0.0;

            for (double i = 3; i <= 1000; i = i + 2)
            {
                series = series + (1 / i);
            }

            Console.WriteLine("{0:f50}", (1 - series));
        }
    }
}
