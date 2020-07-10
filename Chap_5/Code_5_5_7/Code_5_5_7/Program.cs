using System;

namespace Code_5_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values = { 18.88, 11.78, 11.07, 16.12, 12.44, 14.22, 11.78, 15.90, 19.14, 15.66 };

            Stat stat = new Stat();
            double deviation = stat.Deviation(values);
            double mean = stat.Mean(values);

            Console.WriteLine($"Deviation: {deviation}");
            Console.WriteLine($"Mean: {mean}");
        }
    }
}
