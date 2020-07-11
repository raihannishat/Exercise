using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_4_2
{
    public class BideshiDog : Dog
    {
        public override string getType()
        {
            Console.WriteLine("Bideshi Dog");
            return "Bideshi Dog";
        }

        public string getName()
        {
            return "Poodle";
        }
    }
}
