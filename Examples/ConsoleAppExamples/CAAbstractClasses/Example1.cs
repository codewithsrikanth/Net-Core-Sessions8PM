using System;

namespace CAAbstractClasses
{
    interface IA
    {
        void Add(int x, int y);
    }
    interface IB
    {
        void Add(int x, int y);
    }
    class C : IA, IB
    {
        void IA.Add(int x, int y)
        {
            Console.WriteLine("This is IA Interface Add: " + (x + y));
        }
        void IB.Add(int x, int y)
        {
            Console.WriteLine("This is IB Interface Add: " + (x + y));
        }

        //public void Add(int x, int y)
        //{
        //    Console.WriteLine("Addition is: "+(x+y));
        //}
    }
    class Example1
    {
        static void Main(string[] args)
        {
            IA obj1 = new C();
            IB obj2 = new C();
            obj1.Add(100, 200);
            obj2.Add(200, 300);
            
        }
    }
}
