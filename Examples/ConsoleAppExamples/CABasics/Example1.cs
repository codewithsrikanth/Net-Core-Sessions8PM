using System;

namespace CABasics
{
    class Example1
    {
        static void Main()
        {
            int experience, rating;double attendence;
            Console.WriteLine("Enter Employee Exp, Rating(1-5) and Attendence: ");
            experience = Convert.ToInt32(Console.ReadLine());
            rating = Convert.ToInt32(Console.ReadLine());
            attendence = Convert.ToDouble(Console.ReadLine());

            if(experience >= 10 && rating >= 5 &&  attendence >= 95)
                Console.WriteLine("Promotion and 100000");
            else if(experience >= 5 && rating >= 4 && attendence >= 90)
                Console.WriteLine("Senior Employee and 50000");
            else if (experience >= 3 && rating >= 3 && attendence >= 85)
            {
                Console.WriteLine("Performence Bonus");
                Console.WriteLine("Eligible for 30000");
            }                
            else if(attendence < 75)
                Console.WriteLine("Warning - Low Attendence and No Bonus");
            else
                Console.WriteLine("Not Eligible for Bonus");
        }
    }
}
