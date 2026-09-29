using System;
using System.Collections;
using System.Collections.Generic;

namespace CAGenerics
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }
    class Example5
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpID = 101;
            emp.EmpName = "Srikanth";
            emp.Salary = 12345;

            //Employee emp1 = new Employee();
            //emp1.EmpID = 102;
            //emp1.EmpName = "Ramesh";
            //emp1.Salary = 23456;

            //Object Initilizer
            Employee emp1 = new Employee()
            {
                EmpID = 102,
                EmpName = "Ramesh",
                Salary = 23456
            };

            //Collection Intilizer
            List<Employee> empList = new List<Employee>() { emp, emp1, new Employee() { EmpID = 103, EmpName = "Haritha", Salary = 45678 } };

            foreach (Employee item in empList)
            {
                Console.WriteLine($"{item.EmpID}  - {item.EmpName}  - {item.Salary}");
            }
            Console.WriteLine("\n");
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpID = 104,EmpName="Sai",Salary=1234.56},
                new Employee(){EmpID = 104,EmpName="Sai",Salary=1234.56},
                new Employee(){EmpID = 104,EmpName="Sai",Salary=1234.56},
                new Employee(){EmpID = 104,EmpName="Sai",Salary=1234.56},
                new Employee(){EmpID = 104,EmpName="Sai",Salary=1234.56},
                new Employee(){EmpID = 104,EmpName="Sai",Salary=1234.56},
                new Employee(){EmpID = 104,EmpName="Sai",Salary=1234.56}
            };
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.EmpID}  - {item.EmpName}  - {item.Salary}");
            }
        }
    }
}
