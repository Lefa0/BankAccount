using System;
using System.Net.NetworkInformation;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName, physicalAddress;
            double idNumber;
            decimal initialBalance = 0;

            string exit = "1";

            while (exit != "0")
            {
                Console.WriteLine("1. Enter full name: ");
                fullName = Console.ReadLine();

                Console.WriteLine("2. Enter ID Number: ");
                idNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("4. Enter Physical Address: ");
                physicalAddress = Console.ReadLine();

                var myNewAccount = new BankAccount(fullName, idNumber, physicalAddress, initialBalance);
                myNewAccount.CreateAccount();

                Console.WriteLine("Do you want to continue? Enter 0 to exit!");
                exit = Console.ReadLine();
            }

        }
    }
}
