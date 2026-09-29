using System;

namespace CAAbstractClasses
{
    abstract class Employee
    {
        public int empId;
        public string empName;
        public decimal basicalary;
        public Employee(int id, string name, decimal salary)
        {
            empId = id;
            empName = name;
            basicalary = salary;
        }
        //common implementation
        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee ID:{empId} and Name:{empName}");
        }
        public abstract decimal CalSalary();        
    }
    class PermenentEmployee : Employee
    {
        public decimal bonus;
        public PermenentEmployee(int id, string name, decimal salary, decimal bonus) : base(id, name, salary)
        {
            {
                this.bonus = bonus;
            }
        }
        public override decimal CalSalary()
        {
            return basicalary + bonus;
        }
    }
    class ParttimeEmployee : Employee
    {
        public int workingDays;
        public decimal dailyRate;
        public ParttimeEmployee(int id, string name, decimal salary,decimal dailyRate,int days) : base(id, name, 0)
        {
            workingDays = days;
            this.dailyRate = dailyRate;
        }
        public override decimal CalSalary()
        {
            return dailyRate * workingDays;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new PermenentEmployee(101, "Srikanth", 120000, 12000);
            //Employee emp2 = new ParttimeEmployee(102, "Ramesh", 0, 2000, 8);
            //emp1.DisplayEmployee();
            //emp2.DisplayEmployee();


            ISample obj1 = new TV();
            ISample obj2 = new AirConditioner();
            obj1.SwitchOn();
            obj2.SwitchOn();
        }
    }
}
