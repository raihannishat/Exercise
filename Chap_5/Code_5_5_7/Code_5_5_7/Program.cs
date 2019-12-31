using System;

namespace Code_5_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values = { 18.88, 11.78, 11.07, 16.12, 12.44, 14.22, 11.78, 15.90, 19.14, 15.66 };

            Console.WriteLine("Deviation: {0}", Deviation(values));
            Console.WriteLine("Mean: {0}", Mean(values));
        }

        public static double Mean(double[] x)
        {
            double sum = 0.0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }

            return sum / x.Length;
        }

        public static double Variance(double[] x)
        {
            double sum = 0.0;
            double sqarDiff = 0.0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }

            double mean = sum / x.Length;

            for (int i = 0; i < x.Length; i++)
            {
                sqarDiff += (x[i] - mean) * (x[i] - mean);
            }

            return sqarDiff / x.Length;
        }

        public static double Deviation(double[] x)
        {
            return Math.Sqrt(Variance(x));
        }
    }
}
