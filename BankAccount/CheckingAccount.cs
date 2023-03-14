using System;

namespace BankAccount
{
    public class CheckingAccount : BankAccount
    {
        public const double CheckingFee = 0.15;
        public CheckingAccount(string name, double initialAmount)
        {
            FullName = name;
            Balance = initialAmount;
        }
        public CheckingAccount()
        { }
        public override bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= (CheckingFee + amount);
                Console.WriteLine($"An amount R{amount}, was withdrawn from your acccount. Remaining balance: R{Balance}");
                return true;

            }
            else
            {
                Console.WriteLine("Insufficient funds to make this withdrawal");
                return false;
            }
        }
        public override bool Deposit(double amount)
        {
            return base.Deposit(amount);
        }

    }
}
