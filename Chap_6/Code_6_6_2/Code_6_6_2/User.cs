using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_6_2
{
    public class User
    {
        private string name;
        private string emailAddress;

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getEmailAddress()
        {
            return emailAddress;
        }

        public void setEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;
        }
    }
}
