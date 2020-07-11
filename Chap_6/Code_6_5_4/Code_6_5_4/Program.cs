using System;

namespace Code_6_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentEngine paymentEngine = new PaymentEngine();

            BKashPayment bKashPayment = new BKashPayment();

            paymentEngine.accept(bKashPayment);

            CashPayment cashPayment = new CashPayment();

            paymentEngine.accept(cashPayment);
        }
    }
}
