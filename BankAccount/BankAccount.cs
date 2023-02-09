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
        public string IdNumber { get; set; }
        public double PhoneNumber { get; set; }
        public string PhysicalAddress { get; set; }
        public double Balance { get; set; } = 1000;
        public string AccountNumber { get; set; }

        public BankAccount()
        { }
        public BankAccount(string fullName, double phoneNumber, string idNumber, string physicalAddress)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            IdNumber = idNumber;
            PhysicalAddress = physicalAddress;
        }
        public void CreateAccount()
        {
            string fullName, physicalAddress;
            string idNumber;
            double phoneNumber;

            var numb = 657;
            Random random = new Random();
            AccountNumber = (numb.ToString() + random.Next(1000000, 9999999).ToString());

            string exit = "1";
            while (exit != "0")
            {
                Console.WriteLine("TO CREATE A NEW ACCOUNT, PLEASE FOLLOW THE PROMPTS BELOW:");
                Console.WriteLine("#########################################################\n");

                Console.WriteLine("1. Enter full name: ");
                fullName = Console.ReadLine();

                Console.WriteLine("2. Enter ID Number: ");
                idNumber = Console.ReadLine();

                try
                {
                    double idNumberAsDouble = double.Parse(idNumber);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("2. Enter ID Number: ");
                    idNumber = Console.ReadLine();
                }

                Console.WriteLine("3. Enter Phone Number: ");
                phoneNumber = Convert.ToDouble(Console.ReadLine());
                try
                {
                    double phoneNumberAsDouble = double.Parse(idNumber);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("3. Enter Phone Number: ");
                    phoneNumber = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("4. Enter Physical Address: ");
                physicalAddress = Console.ReadLine();

                Console.WriteLine($"An account {AccountNumber} for {fullName} has been been opened on {DateTime.Now}");

                Console.WriteLine("\nDo you want to continue? Enter 0 to exit!");
                exit = Console.ReadLine();
            }

        }
        public void GetBalance()
        {
            Console.WriteLine($"balance: {Balance}");
        }
        public virtual bool Withdraw()
        {
            //Console.WriteLine($"Available balance: {Balance}");
            Console.Write("Enter amount to withdraw: ");
            var amount = Convert.ToDouble(Console.ReadLine());

            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("true");
                return true;
                
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
            
        }
        public virtual bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                Console.WriteLine($"An amount R{amount} was deposited into your account.");
                //Console.WriteLine("true");

                return true;
            }
            else if (amount < 0)
            {
                Console.WriteLine("Please try again!");
                Console.WriteLine("false");
                return false;
            }
            return true;
        }
        public string GetOwner()
        {
            return $"Account Owner {FullName}";
        }
        public string GetAccountNumber() 
        { 
            return AccountNumber;
        }
        
    }
}
