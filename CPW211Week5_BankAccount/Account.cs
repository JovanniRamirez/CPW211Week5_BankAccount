﻿using System;
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
        /// Add a specified amount of money to the account. Returns a new balance
        /// </summary>
        /// <param name="amt">The positive amount to deposit</param>
        /// <returns>The new balance after the deposit</returns>
        public double Deposit(double amt)
        {
            if (amt <= 0)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(amt)} amount must be more than 0");
            }

            Balance += amt;
            return Balance;
        }

        /// <summary>
        /// Withdraw an amount of money from the balance
        /// and returns the updated balance
        /// </summary>
        /// <param name="amount">The positive amount of money to be taken from the balance</param>
        /// <returns>Returns updated balance after withdraw</returns>
        public double Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentException($"{nameof(amount)} cannot be greater then {nameof(Balance)}.");
            }
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(amount)} must be greater than 0.");
            }
            Balance -= amount;
            return Balance;
        }
    }
}
