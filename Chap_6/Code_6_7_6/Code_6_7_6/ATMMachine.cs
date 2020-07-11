using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_7_6
{
    public class ATMMachine
    {
        private string accountNumber = "12462486";
        private string password = "j3GbAeY6";
        private int balance = 50000;

        public string getAccountNumber()
        {
            return accountNumber;
        }

        public string getPassword()
        {
            return password;
        }

        public int getBalance()
        {
            return balance;
        }

        public void withdraw(int balance)
        {
            this.balance -= balance;
            Console.WriteLine("Withdraw successful");
        }

        public void deposit(int balance)
        {
            this.balance += balance;
            Console.WriteLine("Deposit successful");
        }
    }
}
