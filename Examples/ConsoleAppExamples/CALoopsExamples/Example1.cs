using System;

namespace CALoopsExamples
{
    class Example1
    {
        static void Main()
        {
            Console.WriteLine("Enter aby number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            if(num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if(isPrime)
                Console.WriteLine(num +" is a prime number");
            else
                Console.WriteLine(num +" is not a prime number");
        }
    }
}
