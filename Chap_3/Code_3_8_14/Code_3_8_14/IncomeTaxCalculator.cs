using System;
using System.Collections.Generic;
using System.Text;

namespace Code_3_8_14
{
    public class IncomeTaxCalculator
    {
        public double calculateTax(double income)
        {
            if (income <= 250000)
            {
                Console.WriteLine("You will not have to give any Tax");
            }
            else if (income > 250000 && income <= 650000)
            {
                income = income * 0.1;
            }
            else if (income > 650000 && income <= 1150000)
            {
                income = income * 0.15;
            }
            else if (income > 1150000 && income <= 1750000)
            {
                income = income * 0.20;
            }
            else if (income > 1750000 && income <= 4750000)
            {
                income = income * 0.25;
            }
            else
            {
                income = income * 0.30;
            }

            return income;
        }
    }
}
