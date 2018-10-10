using System;

namespace LAB02_UnitTesting
{
    public class Program
    {
        public static double balance = 300.00;

        public static void Main(string[] args)
        {
            
        }

        public static void Balance(double balance)
        {
            Console.WriteLine($"Your current balance is {balance}");
        }

        public static double Withdraw(double amount)
        {
            if (amount > balance)
            {
                return balance;
            }
            else
            {
                return balance -= amount;
            }
        }

        public static double Deposit(double amount)
        {
            if(amount < 0)
            {
                return balance;
            }
            else
            {
                return balance += amount;
            }
        }
    }
}
