using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string FullName { get; set; }
        public double IdNumber { get; set; }
        public string PhysicalAddress { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string fullName, double idNumber, string physicalAddress, decimal balance)
        {
            Balance = balance;
            FullName = fullName;
            IdNumber = idNumber;
            PhysicalAddress = physicalAddress;
        }

        public void CreateAccount()
        {
            Random random = new Random();
            Console.WriteLine($"An account {random.Next(10000000, 99999999)} was created for {FullName}, with intial Balance R {Balance}");
        }
    }
}
