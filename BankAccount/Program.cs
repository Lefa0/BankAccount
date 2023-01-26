using System;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myNewAccount = new BankAccount();
            myNewAccount.CreateAccount();
        }
    }
}
