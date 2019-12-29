using System;

namespace Code_3_8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double W, H, BMI;

            Console.Write("Enter weight in kgs: ");
            W = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height in meters: ");
            H = Convert.ToDouble(Console.ReadLine());

            BMI = W / (H * H);
            Console.WriteLine("BMI: {0}", BMI);
        }
    }
}
