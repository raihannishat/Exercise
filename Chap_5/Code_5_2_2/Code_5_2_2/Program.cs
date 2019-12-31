using System;

namespace Code_5_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();

            int[,] a = matrix.random(5, 5);
            int[,] b = matrix.random(5, 5);

            int[,] multiply = matrix.multiply(a, b);
            Console.WriteLine("Result # 1 : ");
            matrix.print(multiply);

            int[,] add = matrix.add(a, b);
            Console.WriteLine("Result # 2 : ");
            matrix.print(add);

            int[,] subtract = matrix.subtract(a, b);
            Console.WriteLine("Result # 3 : ");
            matrix.print(subtract);
        }
    }
}
