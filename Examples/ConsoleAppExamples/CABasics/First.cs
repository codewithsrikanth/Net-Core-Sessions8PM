using System;

namespace CABasics
{
    class First
    {
        static void Main()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Welcome "+name+ " and your age is: "+age);
        }
    }
}
