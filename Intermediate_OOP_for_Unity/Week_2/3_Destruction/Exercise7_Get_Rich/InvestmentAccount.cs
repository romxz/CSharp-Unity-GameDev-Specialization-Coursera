using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7 {
    abstract class InvestmentAccount {
        #region Fields
        protected float balance;
        #endregion

        #region Constructor
        public InvestmentAccount () {
            balance = 0;
        }
        #endregion

        #region Properties
        float Balance {
            get { return balance; }
        }
        #endregion

        #region Methods
        // Add amount to balance
        virtual public void AddMoney(float amount) {
            if (amount > 0) balance += amount;
            else Console.WriteLine("Amount must be > 0");
        }

        /// <summary>
        /// Update balance
        /// </summary>
        abstract public void UpdateBalance();
        #endregion
    }
}
