using System;
using System.Collections.Generic;
using System.Text;

namespace Code_2_6
{
    public class Person
    {
        private string _name;
        private int _age;
        private string _nationalId;
        private string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        private int age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        private string nationalId
        {
            get { return this._nationalId; }
            set { this._nationalId = value; }
        }
    }
}
