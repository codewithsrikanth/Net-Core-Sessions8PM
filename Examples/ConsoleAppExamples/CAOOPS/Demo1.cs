using System;
using System.Diagnostics;

namespace CAOOPS
{
    class Product
    {
        public string productName;
        public static string categoryName = "Mobile";
    }
    class Demo2
    {
        private Demo2()
        {
            Console.WriteLine("This is Demo2 constructor");
        }
    }


    class Logger
    {
        private static Logger instance;
        private Logger()
        {
            Console.WriteLine("Logger Instance Created");
        }        
        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
    class Sample
    {
        int x; static int y;
        public Sample()
        {
            x = 10;
        }
        static Sample()
        {
            y = 10;
        }
        public void Display()
        {
            Console.WriteLine("Value of x is: " + x);
            x++;
            Console.WriteLine("Value of y is: " + y);
            y++;
        }
    }
    class Demo1
    {
        static void Main(string[] args)
        {
            Logger log1 = Logger.GetInstance();
            Logger log2 = Logger.GetInstance();

            log1.Log("Application Started");
            log2.Log("User Logged In");

            Console.WriteLine("Same Instacne?"+(log1 == log2));

            //Sample obj1 = new Sample();
            //obj1.Display();
            //Sample obj2 = new Sample();
            //obj2.Display();
            //Sample obj3 = new Sample();
            //obj3.Display();



            //Product obj1 = new Product();
            //obj1.productName = "Iphone";

            //Product obj2 = new Product();
            //obj2.productName = "Oneplus";

            //Console.WriteLine(Product.categoryName);
            //Console.WriteLine(obj1.productName);
            //Console.WriteLine(obj2.productName);
        }
    }
}
