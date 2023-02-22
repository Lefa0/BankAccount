using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CreateAccount: BankAccount
    {
        public void PersonalInfor()
        {
            BankAccount newAccount = new BankAccount();

            string exit = "1";
            while(exit != "0")
            {
                Console.WriteLine("TO CREATE YOUR NEW ACCOUNT, PLEASE FOLLOW THE PROMPTS BELOW:");
                Console.WriteLine("###########################################################\n");

                Console.WriteLine("1. Enter Your Full Name: ");
                var fullName = Console.ReadLine();

                Console.WriteLine("2. Enter Your Nationality");
                var citizenShip = Console.ReadLine();

                var idNumber = "";
                var passportNumber = "";
                if (citizenShip == "South African")
                {
                    Console.WriteLine("3. Enter Your ID Number: ");
                   
                    idNumber = Console.ReadLine();
                    newAccount.IDNumberValidation(idNumber);
                }
                else
                {
                    Console.WriteLine("3. Enter Your Passport Number");
                    passportNumber = Console.ReadLine();
                    newAccount.PassportNumberValidation(passportNumber);
                }

                Console.WriteLine("3. Enter Your Phonenumber: ");
                var phoneNumber = Console.ReadLine();
                newAccount.PhoneNumberValidate(phoneNumber);

                Console.WriteLine("4. Enter Your Physical Address: ");
                var physicalAddress = Console.ReadLine();

                Console.WriteLine("\n");
                newAccount = new BankAccount(fullName, phoneNumber, idNumber, passportNumber, physicalAddress, newAccount.CreateAccount());
                
                Console.WriteLine($"An account {newAccount.AccountNumber} for {fullName} has been been opened on {DateTime.Now}.");

                Console.WriteLine("\nENTER 1 to continue creating another new account. ENTER 0 to exit!");
                exit = Console.ReadLine();

            }
        }
    }
}
