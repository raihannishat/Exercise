using System;
using System.Collections.Generic;
using System.Text;

namespace Code_2_3
{
    public class MyClass
    {
        public void printText(string text)
        {
            Console.WriteLine(text);
        }

        public void writeText(string text1, string text2)
        {
            Console.WriteLine(text1);
            Console.WriteLine(text2);
        }

        public int sum(int value1, int value2)
        {
            return value1 + value2;
        }

        public string concat(string value1, string value2)
        {
            if (value1 == null)
            {
                Console.WriteLine("value1 is null");
                throw new ArgumentNullException();
            }

            if (value2 == null)
            {
                Console.WriteLine("value2 is null");
                throw new ArgumentNullException();
            }

            return value1 + value2;
        }
    }
}
