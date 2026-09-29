using System;
using System.Runtime.CompilerServices;

namespace CAInheritence
{
    class Employee1
    {
        public string name;
        public decimal salary;
        public virtual decimal CalculateSalary()
        {
            return salary;
        }
        public virtual string Greet()
        {
            return "Welcome Srikanth";
        }
        public int Calculate(int x,int y)
        {
            return x + y;
        }
    }
    class Manager1 : Employee1 
    {
        public decimal bonus;
        //Method Overriding
        public override decimal CalculateSalary() 
        {
            return salary + bonus;
        }
        //Method Hiding
        public new int Calculate(int x, int y)
        {
            return x * y;
        }
    }
    class Example4
    {
        static void Main(string[] args)
        {
            Manager1 obj = new Manager1();
            System.Console.WriteLine(obj.Greet());
            System.Console.WriteLine(obj.CalculateSalary());
            Console.WriteLine(obj.Calculate(100,300));
        }
    }
}
