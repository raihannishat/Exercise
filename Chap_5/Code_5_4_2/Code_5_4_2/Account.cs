using System;
using System.Collections.Generic;
using System.Text;

namespace Code_5_4_2
{
    public abstract class Account
    {
        private long amount;
        public void deposit(long amount)
        {
            this.amount += amount;
        }

        public long getAmount()
        {
            return amount;
        }

        public abstract long calculateInterest();
    }
}
