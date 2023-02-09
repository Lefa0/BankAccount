﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingsAccount : BankAccount
    {
        double _interestRate = 0.025;
        int _savingsNamber = 0;
        public new string AccountNumber { get; set; }

        //public SavingsAccount(double balance)
        //{
        //    Balance = balance;
        //}
     
        public void PostInterest()
        {
            //calculate one month's worth of interest on the balance
            //and deposit it into the account.

            Balance = Balance * (_interestRate / 12);
            Console.WriteLine($"After monthly interest has been posted, balance = {Balance}");
        }


    }
}