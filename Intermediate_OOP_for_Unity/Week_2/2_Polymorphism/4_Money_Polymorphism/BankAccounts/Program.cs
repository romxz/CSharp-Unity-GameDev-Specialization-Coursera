using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Demonstrates polymorphism
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates polymorphism
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create list and add accounts
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new CheckingAccount(100.00m));
            accounts.Add(new SavingsAccount(50.00m, 0.02m));
            accounts.Add(new CheckingAccount(300.00m));
            accounts.Add(new SavingsAccount(500.00m, 0.02m));
            accounts.Add(new CheckingAccount(1000.00m));
            accounts.Add(new SavingsAccount(50000.00m, 0.02m));

            // deposit $20 into each account
            foreach (BankAccount account in accounts)
            {
                account.MakeDeposit(20.00m);
            }

            // output each account
            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine();
        }
    }
}
