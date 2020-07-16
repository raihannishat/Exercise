using System;

namespace Code_7_13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(5, 5);
        }

        static void Test(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
