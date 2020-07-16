using System;

namespace Code_7_13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                if (a < 10)
                {
                    throw new Exception("Value is too small");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
