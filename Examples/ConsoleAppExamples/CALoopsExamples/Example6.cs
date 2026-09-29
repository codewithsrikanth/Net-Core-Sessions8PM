using System;

namespace CALoopsExamples
{
    class Example6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int size = Convert.ToInt16(Console.ReadLine());

            string[] names = new string[size];
            //Takes the input
            for (int i = 0; i < names.Length; i++) 
            {
                Console.Write($"Enter Student - {i + 1} Name: ");
                names[i] = Console.ReadLine();
            }
            //Display output
            Console.WriteLine("\nStudents Names are: ");
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }
        }
    }
}
