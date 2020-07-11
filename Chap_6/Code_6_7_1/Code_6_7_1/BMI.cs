using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_7_1
{
    public class BMI
    {
        public static readonly double KILOGRAMS_PER_POUND = 0.45359237;
        public static readonly double METERS_PER_INCH = 0.0254;

        private string name;
        private double weight; // in pounds
        private double height; // in inches

        public BMI(string name, double weight, double height)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
        }

        public double getBMI()
        {
            return (weight / height / height) * 703;
        }

        public string getStatus()
        {
            double bmi = getBMI();

            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi < 24.9)
            {
                return "Normal";
            }
            else if (bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }

        public string getName()
        {
            return name;
        }
    }
}
