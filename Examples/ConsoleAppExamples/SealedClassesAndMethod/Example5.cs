using System;

namespace SealedClassesAndMethod
{
    public static class OrderIdGenerator
    {
        private static int _sequence = 1000;
        static OrderIdGenerator()
        {
            Console.WriteLine("OrderId Generator initilized start sequence at "+ _sequence);
        }
        public static string GenerateOrderId()
        {
            _sequence++;
            return $"ORD-{DateTime.Now:yyyyMMdd}-{_sequence}";
        }
    }
    class Example5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OrderIdGenerator.GenerateOrderId()); 
            Console.WriteLine(OrderIdGenerator.GenerateOrderId()); 
            Console.WriteLine(OrderIdGenerator.GenerateOrderId()); 
        }
    }
}
