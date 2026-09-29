using System;
using System.Collections;

namespace CAGenerics
{
    class Example2
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(100); s.Push("Srikanth"); s.Push(true); s.Push(1234.54);
            foreach (object i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            s.Pop();
            foreach (object i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Queue q = new Queue();
            q.Enqueue(101);
            q.Enqueue("Ramesh");
            q.Enqueue(false);
            q.Enqueue(4567.89);
            foreach (object i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            q.Dequeue();
            foreach (object i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
