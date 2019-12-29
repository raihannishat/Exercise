using System;

namespace Code_3_8_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ax, Ay, Bx, By, Cx, Cy, Triangle;

            Console.Write("Enter the value of Ax: ");
            Ax = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of Ay: ");
            Ay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of Bx: ");
            Bx = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of By: ");
            By = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of Cx: ");
            Cx = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of Cy: ");
            Cy = Convert.ToDouble(Console.ReadLine());

            Triangle = Math.Abs((Ax * (By - Cy) + Bx * (Cy - Ay) + Cx * (Ay - By)) / 2);
            Console.WriteLine("The area of the triangle: {0}", Triangle);
        }
    }
}
