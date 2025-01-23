using Batch14oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{

     class BankAccount
    {
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(int accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount}. Remaining balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid amount.");
            }
        }


        //class SavingAccount :BankAccount
        //{

        //    //public SavingAccount(int accountNumber, double balance):base (accountNumber, balance)
        //    //{

        //    //}

        //}
    }



    internal class SealedClassExample
    {

        static void Main()
        {
            Product.GetProductdetails();


            BankAccount account = new BankAccount(3900, 5000);
            account.Deposit(1000);
            account.Withdraw(700);

        }
    }
}


