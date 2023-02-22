using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string FullName { get; set; }
        public string IdNumber { get; set; }
        public string PassportNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string PhysicalAddress { get; set; }
        public double Balance { get; set; } = 1000;
        public string AccountNumber { get; set; }

        public BankAccount()
        { }
        public BankAccount(string fullName, string phoneNumber, string idNumber, string passportNumber, string physicalAddress, string accountNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            IdNumber = idNumber;
            PassportNumber = passportNumber;
            PhysicalAddress = physicalAddress;
            AccountNumber = accountNumber;
        }
        public string CreateAccount()
        {
            var numb = 657;
            Random random = new Random();
            return (numb.ToString() + random.Next(1000000, 9999999).ToString());
        }
        public void GetBalance()
        {
            Console.WriteLine($"balance: {Balance}");
        }
        public virtual bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"An amount R{amount}, was withdrawn from your acccount. Remaining balance: R{Balance}");
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds to make this withdrawal");
                return false;
            }
            
        }
        public virtual bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                Console.WriteLine($"An amount R{amount} was deposited into your account. Your new balance: {Balance}");
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
        public void GetOwner()
        {
            Console.WriteLine($"Account Owner {FullName} of account {AccountNumber}");
        }
        public void GetAccountNumber() 
        {
            Console.WriteLine($"Your account number is {AccountNumber}");
        }

        public string IDNumberValidation(string? idNumber)
        { 
            bool isIdNumberValid = false;
            Regex patternRegex = new Regex(@"(?<Year>[2-9][3-9]|[0])(?<Month>([0][1-9])|([1][0-2]))(?<Day>([0-2][0-9])|([3][0-1]))(?<Gender>[0-9])(?<Series>[0-9]{3})(?<Citizenship>[0-9])(?<Uniform>[0-9])(?<Control>[0-9])");
            isIdNumberValid = patternRegex.IsMatch(idNumber);

            while (isIdNumberValid == false || idNumber.Length != 13) 
            {
                 Console.WriteLine("Invalid input! Please Enter a avalid ID number with 13 numbers only.");
                 Console.WriteLine("2. Enter Your ID Number: ");
                 idNumber = Console.ReadLine();
                 isIdNumberValid = patternRegex.IsMatch(idNumber);
            } 
            return idNumber; 
        }

        public string PhoneNumberValidate(string? phoneNumber) 
        { 
            bool isPhoneNumberValid = false; 
            Regex phoneNumberRegex = new Regex(@"^((?:\+27|27)|0)(72|76|62|63|71|83|84)(\d{7})$");
            isPhoneNumberValid = phoneNumberRegex.IsMatch(phoneNumber);

            while (isPhoneNumberValid == false) 
            { 
                Console.WriteLine("3. Enter phonenumber: "); 
                phoneNumber = Console.ReadLine(); 
                Console.WriteLine("Invalid Input!Please try again");
                isPhoneNumberValid = phoneNumberRegex.IsMatch(phoneNumber);

            }
            return phoneNumber; 
        }

        public string PassportNumberValidation(string? passportNumber)
        {
            bool ispassportNumberValid = false;
            Regex passportNumberRegex = new Regex(@"^[A-Z]{1}-[0-9]{7}$");
            ispassportNumberValid = passportNumberRegex.IsMatch(passportNumber);

            while (ispassportNumberValid == false || passportNumber.Length != 13)
            {
                Console.WriteLine("Invalid input! Please Enter a avalid Passport Number!");
                Console.WriteLine("2. Enter Your Passport Number: ");
                passportNumber = Console.ReadLine();
                ispassportNumberValid = passportNumberRegex.IsMatch(passportNumber);
            }
            return passportNumber;
        }

    }

}
