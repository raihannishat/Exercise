using System;

namespace Code_8_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<string> calculator = new Calculator<string>();
            Console.WriteLine(calculator.add("Hello", "World"));
        }
    }
}
