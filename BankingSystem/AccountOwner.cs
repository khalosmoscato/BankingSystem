using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    internal class AccountOwner
    {
        public int CustomerId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public AccountOwner(int customerId, string firstName, string lastName)
        {
            this.CustomerId = customerId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
