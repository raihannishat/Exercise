using System;

namespace Code_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ara = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Stats<double> stats = new Stats<double>(ara);

            Console.WriteLine(stats.average());
        }
    }
}
