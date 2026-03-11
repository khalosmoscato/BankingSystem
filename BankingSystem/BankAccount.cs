using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public decimal AgreedOverdraft { get; private set; }
        public List<AccountOwner> Owners { get; private set; }
        public List<BankTransaction> Transactions { get; private set; }
        public BankAccount(string accountNumber, decimal agreedOverdraft, AccountOwner newAccountOwner)
        {
            this.AccountNumber = accountNumber;
            this.AgreedOverdraft = agreedOverdraft;

            this.Balance = 0;
            this.Owners = new List<AccountOwner>{newAccountOwner};
            this.Transactions = new List<BankTransaction>();
        }

        // deposit method: increase balance, create a new banktrans and add() that record to transactions list
        public BankTransaction Deposit(BankTransaction transaction)
        {
            // checks if deposit is of a valid amount, if so, add to balance and return the meta data of the transaction, if not display error message:
            if (transaction.Amount > 0)
            {
                Balance += transaction.Amount;
                Transactions.Add(transaction);
                return transaction;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return null;
            }
        }
        // withdraw method needs to check if below 0, or above the balance + agreed overdraft, if it passes the checks, we carry the withdaw and add the new transaction to our list
        public BankTransaction Withdraw(BankTransaction transaction)
        {
            decimal currentFunds = Balance + AgreedOverdraft;
            if (transaction.Amount < 0 || transaction.Amount > currentFunds)
            {
                Console.WriteLine("Invalid input.");
                return null;
            }
            else
            {
                Balance -= transaction.Amount;
                Transactions.Add(transaction);
                return transaction;
            }
        }

    }
}
