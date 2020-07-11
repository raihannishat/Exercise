using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_4_1
{
    public class Shape
    {
        public string name { get; set; }

        public Shape(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
