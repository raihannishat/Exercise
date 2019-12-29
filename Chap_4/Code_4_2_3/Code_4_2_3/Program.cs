using System;

namespace Code_4_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool okay = true;

            do
            {
                Console.WriteLine("Enter a line: ");
                string line = Console.ReadLine();
                Console.WriteLine("You entered: {0}", line);

                if ("quit".Equals(line))
                {
                    okay = false;
                }
            } while (okay);
        }
    }
}
