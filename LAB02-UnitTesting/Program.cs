using System;

namespace LAB02_UnitTesting
{
    public class Program
    {
        public static double balance = 300.00;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM");
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please Choose An Option Below");
                Console.WriteLine("[1] Balance; [2] Withdraw; [3] Deposit; [4] Exit");
                int action = Convert.ToInt16(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Balance();
                        continue;
                    case 2:
                        
                        Console.WriteLine($"Your balance is now: ${Withdraw(AskAmount())}");
                        continue;
                    case 3:
                        Console.WriteLine($"Your balance is now: ${Deposit(AskAmount())}");
                        continue;
                    case 4:
                        exit = true;
                        continue;
                    default:
                        Console.WriteLine("Not an option!");
                        continue;
                }
            }
        }

        public static double AskAmount()
        {
            Console.Write("Please enter amount desired: ");
            string input = Console.ReadLine();
            return CheckInput(input);
        }

            public static double CheckInput(string input)
        {
            try
            {
                return Convert.ToDouble(input);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Not a valid input.  Try again.");
                return AskAmount();
            }
        }

        public static void Balance()
        {
            Console.WriteLine($"Your current balance is ${balance}");
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
