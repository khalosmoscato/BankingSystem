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


    }
}
