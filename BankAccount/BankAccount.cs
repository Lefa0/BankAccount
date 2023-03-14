using System;
using System.Text.RegularExpressions;

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
        public string AccountType { get; set; }

        public BankAccount()
        { }
        public BankAccount(string accountType)
        {
            AccountType = accountType;
        }
        public BankAccount(string fullName, string phoneNumber, string idNumber, string passportNumber, string physicalAddress, string accountNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            IdNumber = idNumber;
            PassportNumber = passportNumber;
            PhysicalAddress = physicalAddress;
            AccountNumber = accountNumber;
        }
        public string CreateAccountNumber()
        {
            var numb = 657;
            Random random = new Random();
            var accountNumber = (numb.ToString() + random.Next(1000000, 9999999).ToString());
            return accountNumber;
        }
        public BankAccount GetPersonalInfor()
        {
            Console.WriteLine("\nPLEASE FOLLOW THE PROMPTS BELOW: ");
            Console.WriteLine("-----------------------------------------------------------\n");

            Console.Write("1. Enter Your FullName: ");
            var fullName = Console.ReadLine();

            Console.Write("2. Enter Your Nationality: ");
            var citizenShip = Console.ReadLine();

            string idNumber = "";
            string passportNumber = "";
            if (citizenShip == "South African")
            {
                Console.Write("3. Enter Your ID Number: ");
                idNumber = Console.ReadLine();
                IDNumberValidation(idNumber);
            }
            else
            {
                Console.Write("3. Enter Your Passport Number: ");
                passportNumber = Console.ReadLine();
                PassportNumberValidation(passportNumber);
            }

            Console.Write("3. Enter Your Phonenumber: ");
            var phoneNumber = Console.ReadLine();
            PhoneNumberValidate(phoneNumber);

            Console.Write("4. Enter Your Physical Address: ");
            var physicalAddress = Console.ReadLine();

            var account = new BankAccount ( FullName = fullName, PhoneNumber = phoneNumber, IdNumber = idNumber, PassportNumber = passportNumber, PhysicalAddress = physicalAddress, AccountNumber = CreateAccountNumber());
            Console.WriteLine($"\nAn account for {FullName} has been been opened on {DateTime.Now}.");
            return account;
        }
        public virtual bool GetBalance()
        {
            Console.WriteLine($"As of {DateTime.Now}, your balance: R{Balance}");
            return true;
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
                Console.Write("2. Enter Your ID Number: ");
                idNumber = Console.ReadLine();
                isIdNumberValid = patternRegex.IsMatch(idNumber);
            }
            return idNumber;
        }
        public string PhoneNumberValidate(string? phoneNumber)
        {
            bool isPhoneNumberValid = false;
            Regex phoneNumberRegex = new Regex(@"^((?:\+27|27)|0)(72|73|76|62|63|71|83|84)(\d{7})$");
            isPhoneNumberValid = phoneNumberRegex.IsMatch(phoneNumber);

            while (isPhoneNumberValid == false)
            {
                Console.WriteLine("Invalid input! Please try again");
                Console.Write("3. Enter phonenumber: ");
                phoneNumber = Console.ReadLine();
                isPhoneNumberValid = phoneNumberRegex.IsMatch(phoneNumber);

            }
            return phoneNumber;
        }
        public string PassportNumberValidation(string? passportNumber)
        {
            bool ispassportNumberValid = false;
            Regex passportNumberRegex = new Regex(@"[A-Z]{1}[0-9]{7}");
            ispassportNumberValid = passportNumberRegex.IsMatch(passportNumber);

            while (ispassportNumberValid == false || passportNumber.Length != 8)
            {
                Console.WriteLine("Invalid input! Please Enter a avalid Passport Number!");
                Console.Write("2. Enter Your Passport Number: ");
                passportNumber = Console.ReadLine();
                ispassportNumberValid = passportNumberRegex.IsMatch(passportNumber);
            }
            return passportNumber;
        }
      
    }
}
