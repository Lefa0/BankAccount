using System;
namespace BankAccount
{
    public class CreditCardAccount:BankAccount
    {
        public double CreditLimit { get; set; } = 1500;
        public new double Balance { get; set; } = 550; 
        public double OverdraftLimit { get; set; } = 300;
        public double InterestRate { get; set; }

        public CreditCardAccount()
        { } 
        public void Payment()
        {
            Console.WriteLine("Enter the payment amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= CreditLimit)
            {
                //makes payment
                Balance -= amount;
                Console.WriteLine($"An amount R{amount} was paid into your account {AccountNumber}. Your balance is now R{Balance}.");
            }
            else
            {
                Console.WriteLine($"Request could not be processed! Your amount R{amount} exceeds the creditlimit {CreditLimit}!");
            }
        }
        public void Purchase()
        {
            Console.WriteLine("Enter the purchase amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount + Balance <= CreditLimit)
            {
                Balance += amount;
                Console.WriteLine($"An amount R{amount} was spent on {DateTime.Now}! Your balance is now {Balance}.");
            }
            else
            {
                Console.WriteLine($"Request could not be processed! Your amount R{amount} exceeds the creditlimit {CreditLimit}!");
            }
        }
        public void Overdraft()
        {
            Console.WriteLine("Enter the purchase amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= CreditLimit + OverdraftLimit)
            {
                //allow for overdraft
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insuffient funds to make purchase!");
            }
        }
        public void GetOverdraftLimit()
        {
            Console.WriteLine($"Your Credit Limit is now R{CreditLimit}");
        }
        public void GetCreditLimit()
        {
            Console.WriteLine($"Your Credit Limit is now R{CreditLimit}");
        }
    }
}
