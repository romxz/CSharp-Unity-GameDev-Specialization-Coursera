using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    /// <summary>
    /// An investment account
    /// </summary>
    public abstract class InvestmentAccount
    {
        #region Fields

        protected float balance;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="deposit">initial deposit</param>
        public InvestmentAccount(float deposit)
        {
            balance = deposit;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the balance in the account
        /// </summary>
        float Balance
        {
            get { return balance; }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds money to the account
        /// </summary>
        /// <param name="amount">amount to add</param>
        public virtual void AddMoney(float amount)
        {
            // validate and update balance
            if (amount >= 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("You can't add a negative amount!");
            }
        }

        /// <summary>
        /// Updates the balance in the account
        /// </summary>
        public abstract void UpdateBalance();

        #endregion
    }
}
