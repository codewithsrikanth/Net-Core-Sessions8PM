using System;

namespace CAInheritence
{
    class Vehicle
    {
        public string brand;
        public int speed;

        public void Start()
        {
            Console.WriteLine($"{brand} is Starting....!");
        }
        public void Stop() => Console.WriteLine($"{brand} is Stopping...!");
    }
    class Car : Vehicle
    {

    }
    class Truck : Vehicle 
    { 
    
    }
    class Bike : Vehicle 
    {
    
    }
    class Example2
    {
        static void Main(string[] args)
        {
            
        }
    }
}
