using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string quit = "YES";
            bool isWorking = true;

            do
            {
                Console.WriteLine("\n GREETINGS! PLEASE ENTER THE NUMBER OF THE ACCOUNT TYPE YOU WOULD LIKE TO CREATE:\n\n Account type options available: \n\n 1.Savings Account \n 2.Checking Account \n 3.Credit Account");
                Console.WriteLine("----------------------------------------------------------------------");
                string _accountType = Console.ReadLine();

                switch (_accountType)
                {
                    case "1":
                        var checkingAccount = new CheckingAccount();
                        //create new account
                        CreateAccount newCheckingAcc = new CreateAccount();
                        Console.WriteLine("\n");
                        newCheckingAcc.PersonalInfor();
                        //withdraw & deposit from checking account
                        CheckingAccount checking = new CheckingAccount("Luka", 100);
                        checking.Withdraw(5);
                        checking.Deposit(5);

                        break;

                    case "2":
                        var savingsAccount = new SavingsAccount();
                        //create new account
                        CreateAccount newSavingsAcc = new CreateAccount();
                        Console.WriteLine("\n");
                        newSavingsAcc.PersonalInfor();
                        //calculate one month's worth of interest on the balance
                        //and deposit it into the account.
                        SavingsAccount mySavings = new SavingsAccount();
                        mySavings.PostInterest();

                        break;

                    case "3":
                        var creditAccount = new CreditCardAccount();
                        //create new account
                        CreateAccount newCreditAcc = new CreateAccount();
                        Console.WriteLine("\n");
                        newCreditAcc.PersonalInfor();
                        //use your creditcard
                        CreditCardAccount myCreditAcc = new CreditCardAccount();
                        myCreditAcc.Credit(5);
                        myCreditAcc.Purchase(5);
                        myCreditAcc.GetOutsBalance();

                        break;

                    default:
                        Console.WriteLine("\nIncorrect input! Enter valid account type!\n");
                        break;

                }
                Console.WriteLine("To exit type in YES,or NO to continue!");
                quit = Console.ReadLine();

                if (quit == "YES")
                    isWorking = false;
            }
            while (isWorking);
        }
    }
 }
