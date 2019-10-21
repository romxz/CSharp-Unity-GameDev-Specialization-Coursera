using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{   
     /// <summary>
     /// An employer-sponsored account
     /// </summary>
    class EmployerSponsoredAccount : MutualFund
    {
        #region Contructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="deposit">initial deposit</param>
        public EmployerSponsoredAccount(float deposit) :
            base(deposit)
        {

        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds money to the account, adding match
        /// </summary>
        /// <param name="amount">amount to add</param>
        public override void AddMoney(float amount)
        {
            base.AddMoney(amount * 2);
        }

        /// <summary>
        /// Provides balance with account type caption
        /// </summary>
        /// <returns>balance with caption</returns>
        public override string ToString()
        {
            return "Employer-Sponsored Account Balance: " + balance;
        }

        #endregion
    }
}
