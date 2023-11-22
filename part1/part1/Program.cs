using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the BankAccount class
            BankAccount account = new BankAccount("mayank kaushal");

            // Deposit and print account details
            account.Deposit(11000);
            account.PrintAccountDetails();

            // Withdraw and print account details
            account.Withdraw(3500);
            account.PrintAccountDetails();

            // Withdraw with insufficient funds and print account details
            account.Withdraw(8500);
            account.PrintAccountDetails();
        }
    }

}
    

