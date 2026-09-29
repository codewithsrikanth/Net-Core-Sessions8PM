using System;

namespace CABasics
{
    class Ifelse
    {
        //MahaniyaTechSolutions - PASCAL casing - Classes, Methods
        //mahaniyaTechSolution - CAMEL casing - varibles
        static void Main()
        {
            double balence = 32000;
            Console.WriteLine("Enter amount to withdraw: ");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= balence)
            {
                Console.WriteLine("Withdrawl Successful!");
                //double remBal = balence - withdraw;
                balence -= withdraw;
                Console.WriteLine("Remaining balance: " + balence);
            }
            else 
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }
}
