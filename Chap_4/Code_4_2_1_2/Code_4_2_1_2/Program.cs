using System;

namespace Code_4_2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n \tlog10(n) \tlog2(2) \tloge(n)");
            int n = 1;

            while (n <= 10)
            {
                double log10 = Math.Log10(n);
                double log2 = Math.Log(n) / Math.Log(2);
                double loge = Math.Log(n);
                string rows = string.Format("{0}: \t{1:f6} \t{2:f6} \t{3:f6}", n, log10, log2, loge);
                Console.WriteLine(rows);
                n++;
            }
        }
    }
}
