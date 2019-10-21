using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{	
	/// <summary>
	/// A savings account that pays interest
	/// </summary>
	public class SavingsAccount : BankAccount
    {		
		#region Fields

		decimal interestRate;

		#endregion

		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="initialDeposit">the initial deposit opening the 
		/// account</param>
		/// <param name="interestRate">the interest rate for the 
		/// account</param>
		public SavingsAccount(decimal initialDeposit, decimal interestRate)
			: base(initialDeposit)
        {
			this.interestRate = interestRate;
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Adds accrued interest to the account balance
		/// </summary>
		public void AccrueInterest()
        {			
			// calculate interest and add to balance
			balance += balance * interestRate;
		}

		#endregion
	}
}
