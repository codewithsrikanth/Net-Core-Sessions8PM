using System;

namespace CAInheritence
{
    class Employee
    {
        public string empName;
        public void ShowDetails()
        {
            Console.WriteLine($"Employee Name is: {empName}");
        }
    }
    class Manager : Employee
    {       
        public double bonus;       
        public void ShowBonus()
        {
            Console.WriteLine($"Employee Bonus is: {bonus}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager emp1 = new Manager();
            emp1.empName = "Srikanth";
            emp1.bonus = 12345;
            emp1.ShowDetails();
            emp1.ShowBonus();            
        }
    }
}
