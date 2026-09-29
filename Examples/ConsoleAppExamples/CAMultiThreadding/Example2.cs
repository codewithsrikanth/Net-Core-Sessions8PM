using System;
using System.Threading;
using System.Threading.Tasks;

namespace CAMultiThreadding
{
    class Example2
    {
        async static void Main(string[] args)
        {
            Task t1 = Task.Run(() =>  PrintNumbers("A"));
            Task t2 = Task.Run(() =>  PrintNumbers("B"));

            Task.WaitAll(t1, t2);

            Console.WriteLine("Both Tasks Completed");
            Thread.Sleep(5000);
        }
        static void PrintNumbers(string label)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{label}: {i}");
            }
        }
    }
}
