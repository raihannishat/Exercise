using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_4
{
    public class MyInterfaceImpl : IMyInterface, IMyOtherInterface
    {
        public void sayBye()
        {
            Console.WriteLine("Hello World!");
        }

        public void sayHello()
        {
            Console.WriteLine("Bye");
        }
    }
}
