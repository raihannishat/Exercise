using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_7_3
{
    public class Author
    {
        private string name;
        private string email;
        private string gender;

        public Author(string name, string email, string gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public string getName()
        {
            return name;
        }

        public string getEmail()
        {
            return email;
        }

        public string getGender()
        {
            return gender;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }
    }
}
