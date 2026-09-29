using System;

namespace SealedClassesAndMethod
{
    partial class Arthematic
    {
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction is: {x - y}");
        }
        partial void Greet(string name)
        {
            Console.WriteLine("Welcome "+name);
        }
    }
}
