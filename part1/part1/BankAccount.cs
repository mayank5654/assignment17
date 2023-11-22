using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    internal class BankAccount
    {
        private static int nextAccountNumber = 1; // Used to automatically generate account numbers

        // Properties
        public int AccountNumber { get; } // Read-only property for the account number
        public string AccountHolderName { get; } // Read-only property for the account holder's name

        private decimal Balance { get; set; } // Private property for the balance

        // Constructor
        public BankAccount(string accountHolderName)
        {
            AccountNumber = nextAccountNumber++;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        // Deposit method allows depositing a positive amount into the account
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
            }
        }

        // Withdraw method allows withdrawing a positive amount if sufficient funds are available
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
            }
        }

        // PrintAccountDetails method prints the account number, account holder's name, and balance
        public void PrintAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: ${Balance}");
            Console.WriteLine();
        }
    }
}

