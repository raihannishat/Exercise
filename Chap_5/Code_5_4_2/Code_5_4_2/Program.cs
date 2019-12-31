using System;

namespace Code_5_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser[] users = new IUser[3];
            users[0] = new DefaultUser("Raihan Nishat");
            users[1] = null;
            users[2] = new DefaultUser("Another user");

            Account[] accounts = new Account[2];
            accounts[0] = new SavingAccount(100);
        }
    }
}
