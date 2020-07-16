using System;
using System.IO;

namespace Code_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader("someFile");
                int i = 0;
                while ( i != -1)
                {
                    i = reader.Read();
                    Console.WriteLine((char) i);
                }
            }
            catch (Exception e)
            {
                // do something clever with the exception
            }
            finally
            {
                if (reader != null)
                {
                    try
                    {
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        // do something clever with the exception
                    }
                }
            }

            Console.WriteLine("--- File End ---");
        }
    }
}
