using System;

namespace Code_7_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main method");
            methodA();
            Console.WriteLine("Exiting main method");
        }

        static void methodA()
        {
            Console.WriteLine("Inside method A");
            methodB();
            Console.WriteLine("Exiting method A");
        }

        static void methodB()
        {
            Console.WriteLine("Inside method B");
            methodC();
            Console.WriteLine("Exiting method B");
        }

        static void methodC()
        {
            Console.WriteLine("Inside method C");
            methodD();
            Console.WriteLine("Exiting method C");
        }

        static void methodD()
        {
            Console.WriteLine("Inside method D");
            int x = 5;
            Console.WriteLine(x / 0);
            Console.WriteLine("Exiting method D");
        }
    }
}
