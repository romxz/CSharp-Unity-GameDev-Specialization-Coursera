using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{	
	/// <summary>
	/// A bank account that accepts deposits and withdrawals.
	/// We can also access the current balance and lists of
	/// deposits and withdrawals for the account
	/// </summary>
	public class BankAccount
    {		
		#region Fields

		protected decimal balance;
		List<decimal> deposits = new List<decimal>();
		List<decimal> withdrawals = new List<decimal>();

		#endregion

		#region Constructors

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="initialDeposit">the initial deposit opening the 
		/// account</param>
		public BankAccount(decimal initialDeposit)
        {			
			// set initial balance and add to list of deposits
			balance = initialDeposit;
			deposits.Add(initialDeposit);
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the balance in the account
		/// </summary>
		public decimal Balance
        {
			get { return balance; }
		}

		/// <summary>
		/// Gets the list of deposits for the account
		/// </summary>
		public List<decimal> Deposits
        {
			get { return deposits; }
		}

		/// <summary>
		/// Gets the list of withdrawals for the account
		/// </summary>
		public List<decimal> Withdrawals
        {
			get { return withdrawals; }
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Adds the deposit to the account. Prints an error
		/// message if the deposit is negative
		/// </summary>
		/// <param name="amount">the amount to deposit</param>
		public void MakeDeposit(decimal amount)
        {			
			// check for valid deposit
			if (amount > 0)
            {				
				// increase balance and add deposit to deposits
				balance += amount;
				deposits.Add(amount);
			}
            else
            {
				// invalid deposit, print error message
				Console.WriteLine(
					"Deposits have to be larger than 0!");
			}
		}

		/// <summary>
		/// Deducts the withdrawal from the account. Prints an error
		/// message if the withdrawal is larger than the account
		/// balance
		/// </summary>
		/// <param name="amount">the amount to withdraw</param>
		public void MakeWithdrawal(decimal amount)
        {			
			// check for valid withdrawal
			if (amount <= balance &&
				amount > 0)
            {
				// deduct withdrawal and add withdrawal to withdrawals
				balance -= amount;
				withdrawals.Add(amount);
			}
            else
            {				
				// invalid withdrawal, print error message
				Console.WriteLine(
					"Not enough money for withdrawal amount!");
			}
		}

		/// <summary>
		/// Converts bank account to string
		/// </summary>
		/// <returns>the string</returns>
		public override string ToString()
        {
			return "Balance: " + balance;
		}

		#endregion
	}
}
