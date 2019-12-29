using System;

namespace com.bazlur.netcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.Name = "XYZ";
            P1.Age = 21;
            P1.Phone = 13579;

            Person P2 = new Person("ABC", 23, 24680);
            P1.Display();
            P2.Display();
        }
    }
}
