using System;
using System.Threading;

namespace CAMultiThreadding
{
    class Example1
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(DoWork,"Task-1");
            ThreadPool.QueueUserWorkItem(DoWork,"Task-2");

            Console.WriteLine("main thread continues...");
            Thread.Sleep(5000);
        }

        static void DoWork(object state)
        {
            Console.WriteLine($"{state} running on thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
