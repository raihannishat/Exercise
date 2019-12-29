using System;

namespace Code_1_6_1
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int a;
            int b;
 
            a = 25;
            b = 99;
            
            int result;
            result = a + b;

            Console.WriteLine("The result is: {0}", result);
        }
        */

        /* 
        static void Main(string[] args)
        {
            int a = 25;
            int b = 99;
            int result = a + b;
            Console.WriteLine("The result is: {0}", result);
        }
        */

        static void Main(string[] args)
        {
            int a = 99;
            int b = 45;

            int addition = a + b;
            int subtraction = a - b;
            int division = a / 9;
            int multiplication = a * 5;

            Console.WriteLine("Addition: {0}", addition);
            Console.WriteLine("Subtraction: {0}", subtraction);
            Console.WriteLine("Division: {0}", division);
            Console.WriteLine("Multiplication: {0}", multiplication);
        }
    }
}
