using System;
using System.Web;

namespace CAOOPS
{
    class Employee
    {
        public int empId;public string empName;public string deptName;public double salary;        
       
        //Default 
        public Employee()
        {
            Console.WriteLine("This is a constructor");
        }
        //Parameterized
        public Employee(int id,string empName)
        {
            empId = id;
            this.empName = empName;
            deptName = string.Empty;
        }
        public Employee(int id, string eName, string dName, double sal)
        {
            empId = id;
            empName = eName;
            deptName = dName;
            salary = sal;
        }
        //Copy Constructor
        public Employee(Employee emp,int empId,string empName)
        {
            this.empId = empId;
            this.empName = empName;
            deptName = emp.deptName;
            salary = emp.salary;
        }
        //Constructor chaining
        public Employee(int id,string empName,string deptName):this(id, empName) 
        {            
            this.deptName = deptName;
        }
        public void Display()
        {
            Console.WriteLine($"Id:{empId}, Name: {empName}, Department: {deptName} and Salary is: {salary}");
        }
        public void Greet()
        {
            Console.WriteLine("This is a Greet Method");
        }
    }

    class Cart
    {
        int itemCount; double totalAmount;
        public Cart()
        {
            itemCount = 0;
            totalAmount = 0;
            Console.WriteLine("New Empty cart created");
        }
    }
    class Demo
    {
        static void Main()
        {
            Employee obj = new Employee(101,"Srikanth","IT",12345);
            obj.Display();

            Employee obj2 = new Employee(obj,102,"Ramesh");           
            obj2.Display();


            //Employee obj = new Employee();
            //obj.Greet();

            //Cart obj1 = new Cart();

            //Employee obj2 = new Employee(101, "Srikanth", "IT");
            //obj2.Display();

            //Employee obj3 = new Employee(102, "Ramesh");
            //obj3.Display();

        }
    }
}
