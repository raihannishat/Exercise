using System;

namespace Code_3_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int anInt = 100;
            long aLong = anInt;   //no explicit casting
            float aFloat = aLong; //no explicit casting

            Console.WriteLine("Int value " + anInt);
            Console.WriteLine("Long value " + aLong);
            Console.WriteLine("Float value {0:#.0}", aFloat);
        }
    }
}
