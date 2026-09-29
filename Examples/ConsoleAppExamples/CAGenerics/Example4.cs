using System;
using System.Collections.Generic;

namespace CAGenerics
{
    class Example4
    {
        static void Main(string[] args)
        {
           Stack<int> s1 = new Stack<int>();
            s1.Push(100); s1.Push(200);
            s1.Push(300); s1.Push(400);
            s1.Push(500); s1.Push(600);
            Console.WriteLine("Elements of Stack are: ");
            foreach (int item in s1)
                Console.Write(item + " ");
            Console.WriteLine();
            s1.Pop();
            foreach (int item in s1)
                Console.Write(item + " ");
            Console.WriteLine();


            Queue<string> courses = new Queue<string>();
            courses.Enqueue("C#.Net");
            courses.Enqueue("ASP.Net Core");
            courses.Enqueue("Micro Services");
            Console.WriteLine("Eelemnts of Queue are: ");
            foreach (string item in courses)
                Console.Write(item + " ");
            Console.WriteLine();
            courses.Dequeue();
            foreach (string item in courses)
                Console.Write(item + " ");
            Console.WriteLine();

            List<int> list = new List<int>();
            list.Add(100);
            int[] ar = { 101, 102, 103, 104 };
            list.AddRange(ar);
            list.Insert(0, 99);
            list.Remove(104);
            Console.WriteLine("Eelements of List are: ");
            foreach(int item in list)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
