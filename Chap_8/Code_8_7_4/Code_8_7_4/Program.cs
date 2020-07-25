using System;
using System.Collections.Generic;

namespace Code_8_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<int, string> hash = new HashTable<int, string>();
            hash.add(1, "Bangladesh");
            hash.add(2, "India");
            hash.add(3, "Pakistan");
            hash.add(4, "Nepal");
            hash.add(5, "Bhutan");
            hash.add(6, "Myanmar");

            hash.print();

            Console.WriteLine();

            hash.remove(1);
            hash.remove(4);
            hash.print();
        }
    }
}
