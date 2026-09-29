using System;

namespace CABasics
{
    class Second
    {
        static void Main()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Marks: ");
            int sub1 = int.Parse(Console.ReadLine());
            double sub2 = double.Parse(Console.ReadLine());
            short sub3 = short.Parse(Console.ReadLine());

            long totalMarks = (long)(sub1 + sub2 + sub3);
            //string total =(string) totalMarks;
            //string total =string.Parse(totalMarks);
            //string total = totalMarks.ToString();

            Console.WriteLine($"Hello {name} and Total marks are: {totalMarks}"); //string interpolation
                                                                                  //Console.WriteLine("Hello"+name+" and Total marks are:"+totalMarks); //string concatination


            //Implicit type casting
            int x = 10;
            double y = x;
            Console.WriteLine("Value of x is: " + x);
            Console.WriteLine("Value of y is: " + y);


            //Explicit Type Casting
            //C++ Type Casting
            double a = 10.23;
            int b = (int)a;
            short c = (short)b;


            Console.WriteLine("Value of a is: " + a);
            Console.WriteLine("Value of b is: " + b);
            Console.WriteLine("Value of c is: " + c);



        }
    }
}
