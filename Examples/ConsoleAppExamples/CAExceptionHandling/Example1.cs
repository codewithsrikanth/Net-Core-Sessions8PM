using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CAExceptionHandling
{
    public class ProductOutOfStockException : Exception
    {
        public string ProductName { get; }
        public ProductOutOfStockException() : base("Product is out of stock.")
        {
        }
        public ProductOutOfStockException(string productName) : base($"{productName} is currenlty out of stock")
        {
            ProductName = productName;
        }
        public ProductOutOfStockException(string message, Exception ex) : base(message, ex)
        {
        }
    }
    public class PaymentFailedException : Exception
    {
        public string TransactionId { get; }
        public decimal AmountShort { get; }
        public PaymentFailedException() : base("Payment couldn't be processed")
        {
        }
        public PaymentFailedException(string msg, string txnId, decimal amount) : base(msg)
        {
            TransactionId = txnId;
            AmountShort = amount;
        }
    }
    public class InvalidOrderException : Exception
    {
        public InvalidOrderException() : base("The Order is Invalid")
        {

        }
        public InvalidOrderException(string msg) : base(msg)
        {

        }
        public InvalidOrderException(string msg, Exception inner) : base(msg, inner) { }
    }

    public class Product
    {
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }
    }

    public class OrderProcessor
    {
        private readonly Dictionary<string, Product> _inventory = new Dictionary<string, Product>()
        {
            {"Laptop",new Product(){Name="Laptop",StockQuantity=0,Price=24000} },
            {"Mouse",new Product(){Name="Mouse",StockQuantity=10,Price=2000} },
            {"Keyboard",new Product(){Name="Keyboard",StockQuantity=5,Price=4000} }
        };

        public void PlaceOrder(string productName, int qty, decimal amountPaid)
        {
            if (qty <= 0)
                throw new InvalidOrderException("Order Quantity must be greater then zero");
            if (!_inventory.ContainsKey(productName))
                throw new InvalidOrderException($"Product: {productName} doesn't in catelog");

            Product product = _inventory[productName];

            if (product.StockQuantity < qty)
                throw new ProductOutOfStockException(productName);

            decimal totalCost = product.Price * qty;
            if (amountPaid < totalCost)
            {
                decimal shortfall = totalCost - amountPaid;
                throw new PaymentFailedException($"Payment Failed, Required: {totalCost:C}, Paid: {amountPaid:C} and Shortby: {shortfall:C}", txnId: Guid.NewGuid().ToString(), shortfall);
            }
        }
    }
    class Example1
    {
        static void Main(string[] args)
        {
            OrderProcessor processor = new OrderProcessor();

            var testOrders = new List<(string product, int qty, decimal paid)>
            {
                ("Laptop",1,20000),
                ("Mouse",2,500),
                ("Mouse",2,1000),
                ("Laptop",-1,55000m),
                ("Keyboard",1,4000m),
                ("Keyboard",15,55000m),
            };
            int testNum = 1;
            foreach (var test in testOrders)
            {
                try
                {
                    processor.PlaceOrder(test.product, test.qty, test.paid);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);  
                }
                finally
                {
                    Console.WriteLine("Logged at"+ DateTime.Now);
                }
                testNum++;  
            }
            Console.WriteLine("All tests Processed, press any key to exit");
        }
    }
}
