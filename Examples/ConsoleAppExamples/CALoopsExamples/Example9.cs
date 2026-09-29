using System;

namespace CALoopsExamples
{
    class Example9
    {
        static void Main(string[] args)
        {
            //Jagged Array
            string[][] employees =
            {
                new string[]{"Rahul", "Priya", "Arjun", "Kiran"},
                new string[]{ "Anjali", "Ravi" },
                new string[]{ "Suresh", "Meena", "Vijay" }
            };

            //Single Dimentional
            string[] depts = { "IT", "HR", "Finance" };

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(depts[i]+" Department: ");
                foreach (var employee in employees[i]) 
                {
                    Console.WriteLine(" - " + employee);
                }
                Console.WriteLine();
            }
            
        }
    }
}
