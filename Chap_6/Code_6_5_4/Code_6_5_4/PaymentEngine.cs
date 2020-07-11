using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_4
{
    public class PaymentEngine
    {
        public void accept(IPayment payment)
        {
            Console.WriteLine($"Accepting payment: {payment.getAmount()}");
        }
    }
}
