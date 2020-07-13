using System;

namespace Code_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {

            }
            catch (ExceptionType name1)
            {
                // catch Block # 1
            }
            catch (ExceptionType name2)
            {
                // catch Block # 2
            }
            */

            try
            {

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {

            }
            catch (Exception ex)
            {
                if (ex is IndexOutOfRangeException || ex is NullReferenceException)
                {
                    Console.WriteLine("Caught an exception");
                }
            }
        }
    }
}
