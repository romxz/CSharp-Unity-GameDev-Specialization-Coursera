using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    /// <summary>
    /// Demonstrates inheritance
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates inheritance
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create accounts
            BankAccount checkingAccount = new CheckingAccount(100.00m);
            BankAccount savingsAccount = new SavingsAccount(50.00m, 0.02m);

            // deposit $20 into each account
            checkingAccount.MakeDeposit(20.00m);
            savingsAccount.MakeDeposit(20.00m);

            // output each account
            Console.WriteLine(checkingAccount);
            Console.WriteLine(savingsAccount);

            // do class-specific operations
            (checkingAccount as CheckingAccount).CashCheck(20.00m);
            (savingsAccount as SavingsAccount).AccrueInterest();

            // output each account
            Console.WriteLine(checkingAccount);
            Console.WriteLine(savingsAccount);

            Console.WriteLine();
        }
    }
}
