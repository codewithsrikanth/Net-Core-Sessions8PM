using System;

namespace CABasics
{
    class Three
    {
        static void Main()
        {
            Console.WriteLine("Enter Product Name: ");
            string pName = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity: ");
            int qty =Convert.ToInt32(Console.ReadLine());

            long total = Convert.ToInt64(price * qty);
            Console.WriteLine($"Product Name:{pName}, Total: {total} ");
        }
    }
}
