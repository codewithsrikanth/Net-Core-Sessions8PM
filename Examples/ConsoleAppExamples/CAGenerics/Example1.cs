using System;
using System.Diagnostics;
using System.Text;

namespace CAGenerics
{
    class Example1
    {
        static void Main(string[] args)
        {
            string x = "Hello";
            string y = x;
            y += " World";

            Console.WriteLine($"Value of x: {x}");
            Console.WriteLine($"Value of y: {y}");


            StringBuilder sb = new StringBuilder("Hello");
            StringBuilder sb1 = sb;
            sb1.Append(" World");

            Console.WriteLine($"sb: {sb}");
            Console.WriteLine($"sb1: {sb1}");

            Stopwatch sw1 = Stopwatch.StartNew();
            string name = "Srikanth";
            for (int i = 0; i < 50000; i++)
            {
                name += i;
            }
            sw1.Stop();

            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < 50000; i++)
            {
                sb2.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("String modification has taken: "+sw1.ElapsedMilliseconds);
            Console.WriteLine("StringBuilder modification has taken: "+sw2.ElapsedMilliseconds);

        }
    }
}
