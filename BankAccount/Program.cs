using System;
using System.Net.NetworkInformation;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var myNewAccount = new BankAccount("Kelly");
            //myNewAccount.CreateAccount();

            myNewAccount.Withdraw();
            myNewAccount.Deposit(5);
            //myNewAccount.GetBalance(); 
            
            //var checking = new CheckingAccount();
            //checking.Withdraw();

            var savings = new SavingsAccount();
            savings.PostInterest();
            
        }
    }
}
