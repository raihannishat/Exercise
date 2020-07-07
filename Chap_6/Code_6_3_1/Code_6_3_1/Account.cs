using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_3_1
{
    public class Account
    {
        private string name { get; set; }
        private long amount { get; set; }

        public Account(string name, long amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public string getName()
        {
            return name;
        }

        public void deposit(long amount)
        {
            this.amount += amount;
        }

        public long getAccount()
        {
            return amount;
        }

        public void setAmount(long amount)
        {
            this.amount = amount;
        }
    }
}
