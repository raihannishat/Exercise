using System;

namespace Code_4_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 7;
            int i = 0;

            while (i <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", t, i, t * i);
                i++;
            }
        }
    }
}
