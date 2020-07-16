using System;

namespace Code_7_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int b = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine($"\nAddition: {calculator.Addition(a, b)}");
                Console.WriteLine($"Subtraction: {calculator.Subtraction(a, b)}");
                Console.WriteLine($"Multiplication: {calculator.Multiplication(a, b)}");
                Console.WriteLine($"Division: {calculator.Division(a, b)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}\n");
                
                Console.Write("Enter a number: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Enter another number: ");
                b = int.Parse(Console.ReadLine());
            }
        }
    }
}
