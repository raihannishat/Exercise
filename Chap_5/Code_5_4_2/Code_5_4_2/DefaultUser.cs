using System;
using System.Collections.Generic;
using System.Text;

namespace Code_5_4_2
{
    public class DefaultUser : IUser
    {
        private string name;

        public DefaultUser(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
