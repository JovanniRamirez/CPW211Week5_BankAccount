using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211Week5_BankAccount
{
    /// <summary>
    /// Represents a single customers bank account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Creates an account with a specific owner and a balance of zero.
        /// </summary>
        /// <param name="accOwner">Customer full name that owns the account</param>
        public Account(string accOwner)
        {
            Owner = accOwner;
        }
        /// <summary>
        /// Account holder full name first and last
        /// </summary>
        public string Owner {  get; set; }

        /// <summary>
        /// The amount of money currently in the account.
        /// </summary>
        public double Balance { get; private set; } //can not set balance outside of the class

        /// <summary>
        /// Add a specified amount of money to the account
        /// </summary>
        /// <param name="amt">The positive amount to deposit</param>
        public void Deposit(double amt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Withdraw an amount of money from the balance
        /// </summary>
        /// <param name="amt">The positive amount of money to be taken from the balance</param>
        public void Withdraw(double amt)
        {
            throw new NotImplementedException();
        }
    }
}
