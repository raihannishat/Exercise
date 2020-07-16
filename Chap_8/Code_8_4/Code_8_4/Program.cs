using System;
using System.Collections;
using System.Collections.Generic;

namespace Code_8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList lst = new ArrayList<string>();
            // List<string> strLst = new ArrayList<string>();

            List<object> objLst = new List<object>();
            objLst.Add(55);
            printList(objLst);

            List<object> strlst = new List<object>();
            strlst.Add("One");
            strlst.Add("Two");
            strlst.Add("Three");
            printList(strlst);
        }

        static void printList(List<object> lst)
        {
            // accept List of Objects only,
            // not List of subclasses of object

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
