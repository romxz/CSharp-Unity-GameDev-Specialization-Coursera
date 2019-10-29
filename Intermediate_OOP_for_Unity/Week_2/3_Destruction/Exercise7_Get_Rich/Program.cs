using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7 {
    class Program {
        static void Main(string[] args) {
            List<InvestmentAccount> accounts = new List<InvestmentAccount>();
            accounts.Add(new SavingsAccount(100, 0.02f));
            accounts.Add(new MutualFund(100));
            accounts.Add(new EmployerSponsoredAccount(100));

            // print balances
            foreach (InvestmentAccount account in accounts) Console.WriteLine(account.ToString());
            Console.WriteLine();
            // update balances
            foreach (InvestmentAccount account in accounts) account.UpdateBalance();
            // print balances again
            foreach (InvestmentAccount account in accounts) Console.WriteLine(account.ToString());
            Console.WriteLine();
            // add $100
            foreach (InvestmentAccount account in accounts) account.AddMoney(100);
            // print balances again
            foreach (InvestmentAccount account in accounts) Console.WriteLine(account.ToString());
            Console.WriteLine();
        }
    }
}
