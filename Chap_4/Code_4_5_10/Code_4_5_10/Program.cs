using System;

namespace Code_4_5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcualator calcualator = new Calcualator();

            int choice;

            do
            {
                Console.WriteLine("Please choose: ");
                Console.WriteLine("1 for addition");
                Console.WriteLine("2 for subtraction");
                Console.WriteLine("3 for multiplication");
                Console.WriteLine("4 for division");
                Console.WriteLine("0 for quit");
                
                Console.Write("# Command: ");
                choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                var result = choice switch
                {
                    1 => calcualator.add(a, b),
                    2 => calcualator.subtrac(a, b),
                    3 => calcualator.multiplication(a, b),
                    4 => calcualator.division(a, b),
                    _ => 0
                };

                Console.WriteLine("Your result: {0}\n", result);

            } while (choice != 0);
        }
    }
}
