using System;
using System.IO;

namespace Code_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entered try staement");
                using (StreamReader sr = new StreamReader("File.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line.Length);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Here in catch Block");
                Console.WriteLine(e.Message);
            }
        }
    }
}
