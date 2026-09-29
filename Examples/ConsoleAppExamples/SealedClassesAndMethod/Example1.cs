using System;

namespace SealedClassesAndMethod
{
    partial class Arthematic
    {
        public void Add(int x,int y)
        {
            Console.WriteLine($"Addition is: {x+y}");
        }
        partial void Greet(string name);
    }
    class Example1
    {
        static void Main(string[] args)
        {
            Arthematic obj = new Arthematic();
            obj.Add(100, 200);
            obj.Sub(100, 200);
            obj.Mul(100, 200);
            obj.Div(100, 200);
        }
    }
}
