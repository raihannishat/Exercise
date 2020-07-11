using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_4
{
    public class BKashPayment : IPayment
    {
        public long getAmount()
        {
            Console.WriteLine("Taking Bkask payment");
            return 100;
        }
    }
}
