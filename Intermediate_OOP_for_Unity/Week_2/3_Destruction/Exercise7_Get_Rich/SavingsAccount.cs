using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7 {
    class SavingsAccount : InvestmentAccount {
        protected float interestRate;

        public SavingsAccount(float deposit, float interestRate) : base(deposit) {
            this.interestRate = interestRate;          
        }

        public override string ToString() {
            return "Savings Account. Balance: " + balance;
        }

        public override void UpdateBalance() {
            balance += balance * interestRate;
        }
    }
}
