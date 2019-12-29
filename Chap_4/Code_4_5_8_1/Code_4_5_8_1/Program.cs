using System;

namespace Code_4_5_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double series = 0.0;

            for (double i = 1; i <= 1000; i++)
            {
                series = series + (1 / i);
            }

            Console.WriteLine("{0:f50}", series);
        }
    }
}
