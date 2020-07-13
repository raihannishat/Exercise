using System;

namespace Code_7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            try
            {
                int result = a / 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(Environment.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }
        }
    }
}
