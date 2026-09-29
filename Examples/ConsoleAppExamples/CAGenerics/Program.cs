using System;

namespace CAGenerics
{
    //Generic Classes
    class Arthematic<A,B>
    {
        public void Add(A x,B y)
        {
            Console.WriteLine($"Value of x: {x} and Value of y is: {y}");
        }
        //Generic Method
        public void PrintValue<T>(T x)
        {
            Console.WriteLine("Value of x is: " + x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arthematic<int,string> obj = new Arthematic<int, string>();
            obj.Add(1234, "Srikanth");
            obj.PrintValue<int>(10);
            obj.PrintValue<string>("Srikanth");
            obj.PrintValue<bool>(true);
            obj.PrintValue<double>(123.456);
        }
    }
}
