using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BankingSystem
{
    internal class Notification
    {
        // creating a timer to give the user time to read a success message
        private const int _dwellTime = 3000;
        // in case of success message, we turn the text gree, wait 3 seconds, then go on with the actions
        public static void Success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Thread.Sleep(_dwellTime);
            Console.ResetColor();   
        }
        public static void Failure(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            // this reads the key, it says `true` because if it didn't and user enters a key, that key would appear in the interface, by adding this `true` it intercepts the pressed key and moves on
            Console.ReadKey(true);
            Console.ResetColor();
        }

    }
}
