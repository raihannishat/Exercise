using System;
using System.Collections.Generic;
using System.Text;

namespace Code_7_13_7
{
    public class Account
    {
        private long balance;

        public void withDraw(long amount)
        {
            balance -= amount;
        }

        public void deposit(long amount)
        {
            balance += amount;
        }
    }
}
