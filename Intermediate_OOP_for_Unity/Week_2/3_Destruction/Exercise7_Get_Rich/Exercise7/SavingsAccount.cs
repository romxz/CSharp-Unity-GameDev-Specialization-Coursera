using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    /// <summary>
    /// A savings account
    /// </summary>
    public class SavingsAccount : InvestmentAccount
    {
        #region Fields

        float interestRate;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="deposit">initial deposit</param>
        /// <param name="interestRate">interest rate</param>
        public SavingsAccount(float deposit, float interestRate) :
            base(deposit)
        {
            this.interestRate = interestRate;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Updates the balance by accruing interest
        /// </summary>
        public override void UpdateBalance()
        {
            // accrue interest
            balance += balance * interestRate;
        }

        /// <summary>
        /// Provides balance with account type caption
        /// </summary>
        /// <returns>balance with caption</returns>
        public override string ToString()
        {
            return "Savings Account Balance: " + balance;
        }

        #endregion
    }
}
