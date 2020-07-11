using System;

namespace Code_6_7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your account no: ");
            string account = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            ATMMachine atmMachine = new ATMMachine();

            if (atmMachine.getAccountNumber().Equals(account) && atmMachine.getPassword().Equals(password))
            {
                Console.WriteLine("Login successful.\n");
                
                Console.WriteLine("Main Menu");
                Console.WriteLine("1: Cheack Balance");
                Console.WriteLine("2: Withdraw");
                Console.WriteLine("3: Deposit");
                Console.WriteLine("4: Exit");               
                
                while (true)
                {
                    Console.Write("Enter chose: ");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 4) break;

                    if (option == 1)
                    {
                        Console.WriteLine($"Current balance is: {atmMachine.getBalance()}"); 
                    }
                    else if (option == 2)
                    {
                        Console.Write("Enter withdraw amount: ");
                        int amount = int.Parse(Console.ReadLine());
                        atmMachine.withdraw(amount);
                    }
                    else if (option == 3)
                    {
                        Console.Write("Enter withdraw amount: ");
                        int amount = int.Parse(Console.ReadLine());
                        atmMachine.deposit(amount);
                    }
                }
            }
        }
    }
}
