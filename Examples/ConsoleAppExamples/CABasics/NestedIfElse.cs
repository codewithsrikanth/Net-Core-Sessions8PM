using System;

namespace CABasics
{
    class NestedIfElse
    {
        static void Main()
        {
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();            
            if (username == "admin")
            {
                Console.WriteLine("Enter Password: ");
                string password = Console.ReadLine();
                if (password == "admin@123")
                {
                    Console.WriteLine("Login Success");
                }
                else
                {
                    Console.WriteLine("Password wrong!");
                }
            }
            else 
            {
                Console.WriteLine("Username is Invalid");
            }



            //if (username == "admin" && password == "admin@123")
            //{
            //    Console.WriteLine("Login Success");
            //}
            //else 
            //{
            //    Console.WriteLine("Invalid Credentials");
            //}
        }
    }
}
