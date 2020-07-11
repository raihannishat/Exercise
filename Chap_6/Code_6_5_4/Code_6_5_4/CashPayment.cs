using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_4
{
    public class CashPayment : IPayment
    {
        public long getAmount()
        {
            Console.WriteLine("Taking cash payment");
            return 500;
        }
    }
}
