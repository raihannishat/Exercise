using System;
using System.Collections.Generic;
using System.Text;

namespace com.bazlur.netcore
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }

        public Person()
        {
            
        }

        public Person(string Name, int Age, int Phone)
        {
            this.Name = Name;
            this.Age = Age;
            this.Phone = Phone;
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Phone: {0}", Phone);
        }
    }
}
