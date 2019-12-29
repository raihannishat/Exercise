using System;

namespace Code_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            double area = circle.getArea();
            Console.WriteLine(area);
        }
    }
}
