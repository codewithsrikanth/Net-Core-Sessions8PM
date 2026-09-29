using System;

namespace CAProperties
{
    class Employee
    {
        int empId; string empName; double salary;
        //Indexers
        public object this[int id]
        {
            set
            {
                if (id == 1)
                    empId = Convert.ToInt32(value);
                if (id == 2)
                    empName = Convert.ToString(value);
                if(id == 3)
                    salary = Convert.ToDouble(value);
            }
            get
            {
                if(id == 1)
                    return empId;
                if (id == 2)
                    return empName;
                if (id == 3)
                    return salary;
                return string.Empty;
            }
        }
        public object this[string name]
        {
            set
            {
                if (name == "id")
                    empId = Convert.ToInt32(value);
                if (name == "name")
                    empName = Convert.ToString(value);
                if (name == "sal")
                    salary = Convert.ToDouble(value);
            }
            get
            {
                if (name == "id")
                    return empId;
                if (name == "name")
                    return empName;
                if (name == "sal")
                    return salary;
                return string.Empty;
            }
        }

    }
    class Example3
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[1] = 101;
            emp[2] = "Srikanth";
            emp[3] = 12345.67;
            Console.WriteLine($"Employee Id:{emp[1]},EmpName: {emp[2]} and Salary is: {emp[3]}");

            Employee emp1 = new Employee();
            emp1["id"] = 102;
            emp1["name"] = "Ramesh";
            emp1["sal"] = 23456.87;
            Console.WriteLine($"Employee Id:{emp1["id"]},EmpName: {emp1["name"]} and Salary is: {emp1["sal"]}");
        }
    }
}
