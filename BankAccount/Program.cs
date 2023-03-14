using System;

namespace BankAccount
{
    enum MenuSelection
    {
        GetBalances = 1,
        Withdraw,
        Deposit,
        IncreaseCredit,
        CreditLimit,
        Overdraft,
        OverdraftLimit,
        Purchase,
        PostInterest,
        Quit
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n WELCOME! PLEASE ENTER THE NUMBER OF THE ACCOUNT TYPE YOU WOULD LIKE TO CREATE:\n\n Account type options available: \n\n 1.Checking Account \n 2.Savings Account \n 3.Credit Account");
            Console.WriteLine("-----------------------------------------------------------");
            
            bool exit = true;
            BankAccount myNewAccount = new BankAccount();

            while (exit)
            {
                 string accountType = Console.ReadLine();
                 var newAcc = new BankAccount(accountType);

                switch (newAcc.AccountType)
                {
                    case "1":
                        //create new account
                        myNewAccount.GetPersonalInfor();
                        Console.WriteLine($"New account number: {myNewAccount.CreateAccountNumber()}");
                        Menu(newAcc.AccountType);
                        break;

                    case "2":
                        //create new account
                        myNewAccount.GetPersonalInfor();
                        Console.WriteLine($"New account number: {myNewAccount.CreateAccountNumber()}");
                        Menu(newAcc.AccountType);
                        break;

                    case "3":
                        //create new account
                        myNewAccount.GetPersonalInfor();
                        Console.WriteLine($"New account number: {myNewAccount.CreateAccountNumber()}");
                        Menu(newAcc.AccountType);
                        break;

                    default:
                        Console.WriteLine("\nIncorrect input! Enter valid account type!\n");
                        break;
                }
            }
        }

        //menu function
        public static void Menu(string items)
        {
            Console.WriteLine("\n MAIN MENU\n PLEASE SELECT OPTION TO PERFORM IN YOUR ACCOUNT:\n\n 1: Balances \n 2: Withdraw \n 3: Deposit \n 4: Increase Credit  \n 5: CreditLimit \n 6: Overdraft \n 7: OverdraftLimit \n 8: Purchase \n 9: PostInterest \n 10: Quit");

            string item = Console.ReadLine();
            CheckingAccount checking = new CheckingAccount();
            SavingsAccount savings = new SavingsAccount();
            CreditCardAccount creditCardAccount = new CreditCardAccount();

            switch (item)
            {
                case "1":
                    //get balances for each account type
                    Console.WriteLine(MenuSelection.GetBalances);
                    if (items == "1")
                    {
                        checking.GetBalance();
                    }
                    else if (items == "2")
                    {
                        savings.GetBalance();
                    }
                    else
                    {
                        creditCardAccount.GetBalance();
                    }
                    break;

                case "2":
                    Console.WriteLine(MenuSelection.Withdraw);
                    if (items == "1")
                    {
                        checking.Withdraw(5);
                    }
                    else if (items == "2")
                    {
                        savings.Withdraw(6);
                    }
                    break;

                case "3":

                    Console.WriteLine(MenuSelection.Deposit);
                    if (items == "1")
                    {
                        checking.Deposit(5);
                    }
                    else if (items == "2")
                    {
                        savings.Deposit(6);
                    }
                    else
                    { Console.WriteLine("Action unavailable for that account type!"); }
                    break;

                case "4":
                    Console.WriteLine(MenuSelection.IncreaseCredit);
                    if (items == "3")
                    {
                        creditCardAccount.Payment();
                    }
                    else
                    {
                        Console.WriteLine("Action unavailable for that account type!");
                    }
                    break;

                case "5":

                    Console.WriteLine(MenuSelection.CreditLimit);
                    if (items == "3")
                    {
                        creditCardAccount.GetCreditLimit();
                    }
                    else
                    {
                        Console.WriteLine("Action unavailable for that account type!");
                    }
                    break;

                case "6":

                    Console.WriteLine(MenuSelection.Overdraft);
                    if (items == "3")
                    {
                        creditCardAccount.Overdraft();
                    }
                    else
                    {
                        Console.WriteLine("Action unavailable for that account type!");
                    }
                    break;

                case "7":

                    Console.WriteLine(MenuSelection.OverdraftLimit);
                    if (items == "3")
                    {
                        creditCardAccount.GetOverdraftLimit();
                    }
                    else
                    {
                        Console.WriteLine("Action unavailable for that account type!");
                    }
                    break;

                case "8":

                    Console.WriteLine(MenuSelection.Purchase);
                    if (items == "3")
                    {
                        creditCardAccount.Purchase();
                    }
                    else
                    {
                        Console.WriteLine("Action unavailable for that account type!");
                    }
                    break;

                case "9":

                    Console.WriteLine(MenuSelection.PostInterest);
                    if (items == "3")
                    {
                        savings.PostInterest();
                    }
                    else
                    {
                        Console.WriteLine("Action unavailable for that account type!");
                    }
                    break;

                case "10":

                    if (items == "1" || items == "2" || items == "3")
                    {
                        Console.WriteLine(MenuSelection.Quit);
                        Console.WriteLine("Goodbye!");
                    }
                    break;

                default:
                    Console.WriteLine(" \nAction unavailable for this account type!");
                    Console.WriteLine($" \n{MenuSelection.Quit}");
                    break;
            }
        }
    }
}
