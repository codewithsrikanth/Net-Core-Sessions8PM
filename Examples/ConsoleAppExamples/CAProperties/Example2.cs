using System;

namespace CAProperties
{
    //DTO(Data Transfer Objects) or POCO(Plain Object CLR Object)
    class Dept
    {
        //Auto-Implemented Properties
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
    class Example2
    {
        static void Main(string[] args)
        {
            Dept dept = new Dept();
            dept.DeptId = 1;
            dept.DeptName = "Test";
            Console.WriteLine($"Department Id is: {dept.DeptId} and Name is: {dept.DeptName}");
        }
    }
}
