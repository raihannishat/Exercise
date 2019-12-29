using System;

namespace Code_3_8_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, r1, r2;

            Console.Write("Enter the value of a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of c: ");
            c = Convert.ToDouble(Console.ReadLine());

            r1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            r2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

            Console.WriteLine("r1 = {0}, r2 = {1}", r1, r2);
        }
    }
}
