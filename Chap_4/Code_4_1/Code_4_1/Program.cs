using System;

namespace Code_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 76;
            char grade;

            if (score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'B';
            }
            else if (score >= 70)
            {
                grade = 'C';
            }
            else if (score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine("Grade = {0}", grade);
        }
    }
}
