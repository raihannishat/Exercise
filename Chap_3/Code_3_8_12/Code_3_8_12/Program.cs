using System;

namespace Code_3_8_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            Console.Write("Option: ");
            int Option = Convert.ToInt32(Console.ReadLine());

            if (Option == 1)
            {
                Console.Write("Enter temperature in Celsius: ");
                double C = Convert.ToDouble(Console.ReadLine());
                double F = (9 / 5) * C + 32;
                Console.WriteLine("Fahrenheit: {0}", F);
            }
            else if (Option == 2) 
            {
                Console.Write("Enter temperature in Fahrenheit: ");
                double F = Convert.ToDouble(Console.ReadLine());
                double C = (F - 32) / (9 / 5);
                Console.WriteLine("Celsius: {0}", C);
            }
        }
    }
}
