using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private decimal Balance { get; set; }

        public BankAccount()
        {
            Balance = 0;
        }

        public void CreateAccount()
        {       
                string exit = "Yes";
                bool isWorking = true;
            do
            {
                Console.WriteLine("1. Enter full name: ");
                var fullName = Console.ReadLine();

                Console.WriteLine("2. Enter ID Number: ");
                string idNumber = Console.ReadLine();

                Console.WriteLine("4. Enter Physical Address: ");
                string physicalAdress = Console.ReadLine();

                Random random = new Random();
                Console.WriteLine("\n===============================================================");
                Console.WriteLine($"An account {random.Next(10000000, 99999999)} was created for {fullName}, with intial Balance R{Balance}");

                Console.WriteLine("\n");

                Console.WriteLine("To exit, type 'Yes'.");
                exit = Console.ReadLine();

                if (exit == "Yes")
                    isWorking = false;
            }
            while(isWorking);
        }
    }
}
