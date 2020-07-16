using System;

namespace Code_7_13_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                methodA();
                doNotCallMe();
                methodB();
            }
            catch (XyzException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Console.WriteLine("Inside finally block");
            }

            Console.WriteLine("End of the main method");
        }

        static void methodA()
        {
            Console.WriteLine("Inside method A");
        }

        static void methodB()
        {
            Console.WriteLine("Inside method B");
            throw new XyzException();
        }

        static void doNotCallMe()
        {
            throw new Exception("You can't call this method!");
        }
    }
}
