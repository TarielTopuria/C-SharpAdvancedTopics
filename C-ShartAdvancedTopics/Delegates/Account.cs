using C_ShartAdvancedTopics.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ShartAdvancedTopics.Delegates
{
    public delegate void AccountStateHandler(string text);
    public class Account
    {
        AccountStateHandler accountStateHandler;
        public void SetAcountStateHandler(AccountStateHandler _accountStateHandler)
        {
            accountStateHandler += _accountStateHandler;
        }

        public void UnsetAcountStateHandler(AccountStateHandler _accountStateHandler)
        {
            accountStateHandler -= _accountStateHandler;
        }

        private decimal Balance { get; set; }

        public Account(decimal Balance) => this.Balance = Balance;

        public void Fill(decimal Balance)
        {
            this.Balance += Balance;
            accountStateHandler?.Invoke($"{Balance} added to your account. Current balance is {this.Balance}.");
        }

        public void Withdraw(decimal Balance)
        {
            if (this.Balance > Balance)
            {
                this.Balance -= Balance;
                if (accountStateHandler != null)
                    accountStateHandler?.Invoke($"{Balance} withdrawed from your account. Current balance is {this.Balance}.");
            }
            else
            {
                if (accountStateHandler != null)
                    accountStateHandler?.Invoke($"There is not enought amount of money on your account.");
            }
        }

        public static void DisplayInfoInConsole(string text)
        {
            Console.WriteLine(text);
        }
        public static void DisplayInfoInFile(string text)
        {
            string path = @"C:\Users\TTopuria\Desktop\Logger\Log.xml";
            File.WriteAllText(path, text);
        }
    }
}
