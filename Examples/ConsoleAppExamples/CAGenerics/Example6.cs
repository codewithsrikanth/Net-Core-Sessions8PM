using System;
using System.Collections.Generic;

namespace CAGenerics
{
    class Example6
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> studentNames = new Dictionary<int, string>()
            //{
            //    {101,"Srikanth" },
            //    {102,"Ramesh" },
            //    {103,"Suresh" },
            //    {104,"Krish" }
            //};
            //foreach (var item in studentNames.Keys) 
            //{
            //    Console.WriteLine(studentNames[item]);
            //}

            Dictionary<string,List<string>> deptEmps = new Dictionary<string,List<string>>();

            //Local Functions
            void AddEmployee(string dept,string empName)
            {
                if (!deptEmps.ContainsKey(dept))
                    deptEmps[dept] = new List<string>();

                deptEmps[dept].Add(empName);
            }

            AddEmployee("IT", "Srikanth");
            AddEmployee("IT", "Athresh");
            AddEmployee("IT", "Praveen");
            AddEmployee("QA", "Prashanth");
            AddEmployee("HR", "Meena");

            foreach (var dept in deptEmps)
            {
                Console.WriteLine($"Department: {dept.Key}");
                foreach (var emp in dept.Value)
                {
                    Console.WriteLine($" - {emp}");
                }
            }
        }
    }
}
