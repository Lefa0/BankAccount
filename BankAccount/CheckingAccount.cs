using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CheckingAccount:BankAccount
    {
        public const double Fee = 0.15;

        public CheckingAccount()
        { }
        public override bool Withdraw()
        {
            Console.WriteLine($"Available balance: {Balance}");

            Console.Write("Enter amount to withdraw: ");
            var amount = Convert.ToDouble(Console.ReadLine());

            if (Balance >= amount)
            {
                Balance -= (Fee + amount);
                Console.WriteLine($"An amount R{amount}, was withdrawn from your acccount. Remaining balance: R{Balance}");
                return true;

            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }
    }
}
