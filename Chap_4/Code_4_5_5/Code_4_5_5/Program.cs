using System;

namespace Code_4_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 49;
            GradeCalculator calculator = new GradeCalculator();
            string grade = calculator.calculate(number);
            Console.WriteLine("Your grade is: {0}", grade);
        }
    }
}

/* [Note] -> Grading System: https://www.bracu.ac.bd/academics/policies-and-procedures */
