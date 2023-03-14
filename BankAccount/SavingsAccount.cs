using System;

namespace BankAccount
{
    public class SavingsAccount : BankAccount
    {
         public double _interestRate = 0.025;
        public new string AccountNumber { get; set; }
        public void PostInterest()
        {
            //calculate one month's worth of interest on the balance
            //and deposit it into the account.
            Balance += Balance * (_interestRate / 12);
            Console.WriteLine($"\nAfter monthly interest has been posted, balance = R{Balance}");
        }
    }
}
