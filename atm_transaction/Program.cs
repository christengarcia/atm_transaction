/*
 * C# Program to Display the ATM Transaction
 */

using System;

namespace atm_transaction
{
    class Program
    {
        public static void Main()
        {

            int amount = 1000, deposit, withdraw;
            int choice, pin = 0, x = 0;
            Console.WriteLine("Enter Your Pin Number ");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("********Welcome to ATM Service**************\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("*********************************************\n\n");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice) static void Main(string[] args)
            }
        }
    }
}

