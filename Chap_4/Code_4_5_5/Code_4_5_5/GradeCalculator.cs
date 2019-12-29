using System;
using System.Collections.Generic;
using System.Text;

namespace Code_4_5_5
{
    public class GradeCalculator
    {
        public string calculate(int number)
        {
            if (number >= 90 && number <= 100)
            {
                return "A";
            }
            else if (number >= 85 && number <= 90)
            {
                return "A-";
            }
            else if (number >= 80 && number <= 85)
            {
                return "B+";
            }
            else if (number >= 75 && number <= 80)
            {
                return "B";
            }
            else if (number >= 70 && number <= 75)
            {
                return "B-";
            }
            else if (number >= 65 && number <= 70)
            {
                return "C+";
            }
            else if (number >= 60 && number <= 65)
            {
                return "C";
            }
            else if (number >= 57 && number <= 60)
            {
                return "C-";
            }
            else if (number >= 55 && number <= 57)
            {
                return "D+";
            }
            else if (number >= 52 && number <= 55)
            {
                return "D";
            }
            else if (number >= 50 && number <= 52)
            {
                return "D-";
            }
            else
            {
                return "F";
            }
        }
    }
}
