using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_7_4
{
    public class UseAnimal
    {
        public void doSomething(Animal animal)
        {
            Console.WriteLine("Inside animal version");
        }

        public void doSomething(Horse animal)
        {
            Console.WriteLine("Inside hourse version");
        }
    }
}
