using System;

namespace Code_3_8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            IncomeTaxCalculator Calculator = new IncomeTaxCalculator();
            double tax = Calculator.calculateTax(income);

            Console.WriteLine("Your total income is: {0}", income);
            Console.WriteLine("The ammount of tax is:: {0}", tax);
        }
    }
}
