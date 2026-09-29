using System;

namespace CABasics
{
    //Simple If
    class Four
    {
        static void Main()
        {
            Console.WriteLine("Enter your marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if(marks >= 90)
            {
                Console.WriteLine("Congratulations! you are eligibile for a scholarship");
            }            
        }
    }
}
