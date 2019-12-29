using System;

namespace Code_3_6_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double aDouble = 97.04;
            long aLong = (long)aDouble; //explicit type casting
            int aInt = (int)aLong;      //explicit type casting

            Console.WriteLine("Double value " + aDouble);
            Console.WriteLine("Long value " + aLong);
            Console.WriteLine("Int value " + aInt);
        }
    }
}
