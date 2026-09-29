using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CAMultiThreadding
{
    class Example4
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main()
        {
            Console.WriteLine("Featching Data: ");
            string data = await FeatchDataAsync("https://jsonplaceholder.typicode.com/todos/1");
            Console.WriteLine("Recived..."+data);
            
        }
        static async Task<string> FeatchDataAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
