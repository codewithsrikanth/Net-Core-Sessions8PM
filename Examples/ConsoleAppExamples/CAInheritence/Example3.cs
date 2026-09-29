using System;

namespace CAInheritence
{
    class Example3
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition is: {x + y}");
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine($"Addition is: {a + b + c}");
        }
        public void Add(string x, string y)
        {
            Console.WriteLine($"My Name is: {x + y}");
        }
        static void Main(string[] args)
        {
            Example3 obj= new Example3();
            obj.Add(10, 20);
            obj.Add("Sri", "Kanth");
            obj.Add(10, 20, 30);
        }
    }
}
