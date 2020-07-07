using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Code_6_3_5
{
    public class Account : BaseAccount
    {
        private long amount { get; set; }

        public sealed override void deposit(long amount)
        {
            this.amount += amount;
        }

        public long getAmount()
        {
            return amount;
        }
    }
}
