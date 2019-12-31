using System;
using System.Collections.Generic;
using System.Text;

namespace Code_5_5_7
{
    public class Stat
    {
        public double Mean(double[] x)
        {
            double sum = 0.0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }

            return sum / x.Length;
        }

        public double Variance(double[] x)
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

        public double Deviation(double[] x)
        {
            return Math.Sqrt(Variance(x));
        }
    }
}
