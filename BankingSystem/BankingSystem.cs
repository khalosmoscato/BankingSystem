using System; 
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    internal class BankingSystem
    {
        public List<BankAccount> Accounts { get; private set; }
        public BankingSystem()
        {
            this.Accounts = new List<BankAccount>();
        }
        // Search needs to check if the account num is found in our list of bank accounts, if so we return that account so we can perform more actions for the registered user, otherwise return null
        public BankAccount Search(string accounNumbert)
        {
            foreach (BankAccount account in Accounts)
            {
                if (account.AccountNumber == accounNumbert)
                {
                    return account;
                }
                
            }
            return null;
        }
    }
}
