using System;

namespace CALoopsExamples
{
    class Example2
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            Console.WriteLine("Enter any number: ");
            int number = Convert.ToInt32(Console.ReadLine()); //12345 => 54321
            int reverse = 0;
            while(number > 0)
            {
                int digit = number % 10; 
                reverse = reverse * 10 + digit; 
                number = number / 10;
            }
            Console.WriteLine("Reverse number is: "+reverse);
        }
    }
}
