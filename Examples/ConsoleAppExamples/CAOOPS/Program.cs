using System;

namespace CAOOPS
{
    //Class
    class Car
    {
        //Data members 
        string color;string brandName;double price;
        //Method: Used to execute the logic whenever we call
        public void GetCarDetails()
        {
            Console.WriteLine("Enter car details: ");
            color = Console.ReadLine();
            brandName = Console.ReadLine();
            price = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayCarDetails()
        {
            Console.WriteLine($"Car color:{color}, Brand is: {brandName} and Price is: {price}");
        }  
        //Fucntion
        public string Greet()
        {
            return "Welcome to OOPS";
        }

        public int Add(int x,int y)
        {
            return x + y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //Object
            Car obj1 = new Car();
            //obj1.GetCarDetails();
            //obj1.DisplayCarDetails();
            //string x = obj1.Greet();
            //Console.WriteLine(x);

            Console.WriteLine(obj1.Add(10, 20)); 

            Car obj2 = new Car();
            //obj2.GetCarDetails();
            //obj2.DisplayCarDetails();
            obj2.Greet();
        }
    }
}
