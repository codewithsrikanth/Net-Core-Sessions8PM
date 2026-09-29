using System;
using System.Net;

namespace CABasics
{
    class Example2
    {
        static void Main(string[] args)
        {
            double balence = 45000;
            Console.WriteLine("ATM Menu");
            Console.WriteLine("1. Check Balence\n2. Deposit\n3. Withdraw\n4. Exit");

            Console.WriteLine("Enter your choice(1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    Console.WriteLine($"Available balence is: {balence}");
                    break;
                case 2:
                    Console.WriteLine("Enter deposit amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    balence += amount;//balence = balence + amount
                    Console.WriteLine($"Updated Balence is: {balence}");
                    break;
                case 3:
                    Console.WriteLine("Enter withdraw amount: ");
                    double withdrawamount = Convert.ToDouble(Console.ReadLine());
                    if (withdrawamount <= balence)
                    {
                        balence -= withdrawamount;
                        Console.WriteLine("Please collect cash");
                        Console.WriteLine($"Remaining Balence is: {balence}");
                    }
                    else 
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                    break;
                case 4:
                    Console.WriteLine("Thanks for using ATM");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;


            }


        }
    }
}
