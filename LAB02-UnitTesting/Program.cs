using System;

namespace LAB02_UnitTesting
{
    public class Program
    {
        public static double balance = 300.00;

        public static void Main(string[] args)
        {
            Balance(balance);
            Console.WriteLine(Withdraw(5.00));
        }

        public static void Balance(double balance)
        {
            Console.WriteLine($"Your current balance is {balance}");
        }

        public static double Withdraw(double amount)
        {
            return balance -= amount;
        }
    }
}
