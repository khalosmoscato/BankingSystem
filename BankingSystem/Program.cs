using System.Globalization;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankingSystem myBank = new BankingSystem();
            bool isMenuOn = true;
            while (isMenuOn)
            {
                Console.Clear();
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Search Account");
                Console.WriteLine("3. Apply Yearly Interests");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        // add account
                        Console.WriteLine("Insert your First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Insert your Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Insert your Account Number");
                        string costumerId = Console.ReadLine();
                        int parsedCostumerId = int.Parse(costumerId);
                        Console.WriteLine("Insert your Agreed Overdraft");
                        decimal agreedOverdraft = decimal.Parse(Console.ReadLine());
                        AccountOwner client1 = new AccountOwner(parsedCostumerId, firstName, lastName);
                        BankAccount acc1 = new BankAccount(costumerId, agreedOverdraft, client1);
                        if (myBank.AddAccount(acc1))
                        {
                            Notification.Success("Account added!");
                        }
                        else
                        {
                            Notification.Failure("You already have an account.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Insert your account number.");
                        string accountNumber = Console.ReadLine();
                        var accountMatch = myBank.Search(accountNumber);
                        if (accountMatch != null)
                        {
                            Console.WriteLine($"Account Holder: {accountMatch.Owners[0].FirstName}");
                            // the :C is a Format Specifier that tells the computer to format this number as Currency
                            Console.WriteLine($"Current Balance: {accountMatch.Balance:C}");
                            Console.WriteLine("\nPress any keys to exit.");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            Notification.Failure("Invalid account number.");
                        }
                        // search
                        break;
                    case "3":
                        //
                        Console.WriteLine("Enter interst rate percentage");
                        // the user will put an int like 5 to represnet 5% interest, because we need to use this as a multiplier on the current account owners balances, we need this number to be like 0.05 which means we need to divide the input number by 100
                        decimal rate = decimal.Parse(Console.ReadLine()) / 100;
                        myBank.ApplyYearlyInterests(rate);
                        Notification.Success("Interest applied!");
                        break;
                    case "4":
                        // exit menu
                        isMenuOn = false;
                        break;
                    default:
                        // invalid inputs
                        Notification.Failure("Invalid selection. Please choose option 1 to 4.");
                        break;
                }
            }
        }
    }
}
