using System;
using System.Collections;

namespace CAGenerics
{
    class Example3
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            //Console.WriteLine($"Initial ArrayList Capacity:{al.Capacity} and Count:{al.Count}");
            al.Add(100); al.Add(200); al.Add(300);
            al.Add(400);al.Add(500);al.Add(600);
            //Console.WriteLine($"After Elements Added ArrayList Capacity:{al.Capacity} and Count:{al.Count}");
            foreach (var item in al)            
                Console.Write(item + " ");
            Console.WriteLine();

            int[] marks = {12,34,55,65,32 };
            al.AddRange(marks);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            al.Insert(2, 250);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            al.InsertRange(2,marks);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            Console.WriteLine("Contains 200? "+al.Contains(200));

            al.Remove(100);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            al.RemoveRange(2, 4);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            al.Sort();
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            al.Reverse();
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
