using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CreditCardAccount:BankAccount
    {
        public double CreditLimit { get; set; } = 1000;
        public double OverdraftLimit { get; set; } = 50;
        public new double Balance { get; set; }
        public double InterestRate { get; set; }

        public CreditCardAccount()
        { } 
        public void Credit(double amount)
        {
            if (amount <= CreditLimit)
            {
                //makes payment
                Balance -= amount;
                Console.WriteLine($"An amount R{amount} was paid into your account {AccountNumber}. Your balance is now {Balance}.");
            }
            else
            {
                Console.WriteLine($"Request could not be processed! Your amount R{amount} exceeds the creditlimit {CreditLimit}!");
            }
           
        }
        public void Purchase(double amount)
        {
            if (amount <= CreditLimit)
            {
                Balance += amount;
                Console.WriteLine($"An amount R{amount} was spent on {DateTime.Now}! Your balance is now {Balance}.");
            }
            else
            {
                Console.WriteLine($"Request could not be processed! Your amount R{amount} exceeds the creditlimit {CreditLimit}!");
            }
        }
        public void Overdraft(double amount)
        {
            if (amount <= CreditLimit + OverdraftLimit)
            {
                //allow for overdraft
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Insuffient funds to make purchase!");
            }
        }
        public void GetCreditLimit()
        {
            Console.WriteLine($"Your Credit Limit is now R{CreditLimit}");
        }
        public void GetOutsBalance()
        {
            Console.WriteLine($"As of {DateTime.Now}, Your balance is R{Balance}!");
        }






    }
}
