using System;
using System.Security.Cryptography;

namespace CALoopsExamples
{
    class Example3
    {
        static void Main(string[] args)
        {
            //int i = 200;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 5);

            string pwd;

            do
            {
                Console.WriteLine("Enter password");
                pwd = Console.ReadLine();

                if (pwd != "admin123")
                {
                    Console.WriteLine("Incorrect password retry one more time");
                }
            } while (pwd != "admin123");
            Console.WriteLine("Login Success");
        }
    }
}
