using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    /// <summary>
    /// Exercise 7
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates inheritance and polymorphism
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // build list of accounts
            List<InvestmentAccount> accounts = new List<InvestmentAccount>();
            accounts.Add(new SavingsAccount(100, 0.03f));
            accounts.Add(new MutualFund(100));
            accounts.Add(new EmployerSponsoredAccount(100));

            // print balances
            foreach (InvestmentAccount account in accounts)
            {
                Console.WriteLine(account);
            }

            // update balances
            foreach (InvestmentAccount account in accounts)
            {
                account.UpdateBalance();
            }

            // print balances
            Console.WriteLine();
            foreach (InvestmentAccount account in accounts)
            {
                Console.WriteLine(account);
            }

            // add money
            foreach (InvestmentAccount account in accounts)
            {
                account.AddMoney(100);
            }

            // print balances
            Console.WriteLine();
            foreach (InvestmentAccount account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine();
        }
    }
}
