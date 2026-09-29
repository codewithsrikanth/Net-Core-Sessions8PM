using System;
using System.Threading.Tasks;

namespace CAMultiThreadding
{
    class Example3
    {
        static async Task Main()
        {
            Console.WriteLine("Step-1: Before calling async method");

            string result = await GetGreetingAsync();

            Console.WriteLine("Step-4: Before calling async method");
        }
        static async Task<string> GetGreetingAsync()
        {
            Console.WriteLine("Step-2: Inside Async Method, starting delay");
            await Task.Delay(5000);
            Console.WriteLine("Step-3: Delay finished, resuming method");
            return "Hello Srikanth";
        }
    }
}
