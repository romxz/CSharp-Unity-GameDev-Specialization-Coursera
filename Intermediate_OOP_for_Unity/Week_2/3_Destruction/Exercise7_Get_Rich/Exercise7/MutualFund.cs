using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    /// <summary>
    /// A mutual fund
    /// </summary>
    public class MutualFund : InvestmentAccount
    {
        const float ServiceChargePercent = 0.01f;

        #region Contructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="deposit">initial deposit</param>
        public MutualFund(float deposit) :
            base(deposit)
        {

        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds money to the account, deducting a
        /// service charge
        /// </summary>
        /// <param name="amount">amount to add</param>
        public override void AddMoney(float amount)
        {
            base.AddMoney(amount * (1 - ServiceChargePercent));
        }

        /// <summary>
        /// Updates the balance by checking investment values
        /// </summary>
        public override void UpdateBalance()
        {
            // update based on investment values (assume 6% growth)
            balance *= 1.06f;
        }

        /// <summary>
        /// Provides balance with account type caption
        /// </summary>
        /// <returns>balance with caption</returns>
        public override string ToString()
        {
            return "Mutual Fund Balance: " + balance;
        }

        #endregion
    }
}

