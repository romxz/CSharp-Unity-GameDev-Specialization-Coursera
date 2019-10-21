using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{	
	/// <summary>
	/// A checking account that lets us cash checks and access the list of 
	/// checks that have been cashed
	/// </summary>
	public class CheckingAccount : BankAccount
    {		
		#region Fields

		List<decimal> checks = new List<decimal>();

		#endregion

		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="initialDeposit">the initial deposit opening the 
		/// account</param>
		public CheckingAccount(decimal initialDeposit)
			: base(initialDeposit)
        {
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the list of checks for the account
		/// </summary>
		public List<decimal> Checks
        {
			get { return checks; }
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Cashes the check of the given amount. Prints an
		/// error message if the check amount is larger than 
		/// the account balance
		/// </summary>
		/// <param name="amount">the amount of the check</param>
		public void CashCheck(decimal amount)
        {			
			// check for valid check amount
			if (amount <= balance)
            {				
				// deduct check and add check to checks
				balance -= amount;
				checks.Add(amount);
			}
            else
            {				
				// invalid check, print error message
				Console.WriteLine(
					"Not enough money in account to cover check");
			}
		}

		#endregion
	}
}
