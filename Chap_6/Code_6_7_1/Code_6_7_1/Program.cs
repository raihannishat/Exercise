using System;

namespace Code_6_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI bmi = new BMI("Tanvir Rifat", 145, 70);
            Console.WriteLine($"The BMI for {bmi.getName()} is ({bmi.getBMI():0.00}) {bmi.getStatus()}");
        }
    }
}
