using System;
using System.Threading;

namespace CAMultiThreadding
{
    class Sample
    {
        //SQLServer
        public void F1()
        {
            Console.WriteLine("Sql Server App");
            for (int i = 0; i < 100; i++) 
            {
                Console.WriteLine(i);
            }
        }
        //Oracle
        public void F2()
        {
            Console.WriteLine("Oracle App");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10000);
            }
        }
        //Mango DB
        public void F3()
        {
            Console.WriteLine("Mango DB App");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            //obj.F1();
            //obj.F2();
            //obj.F3();

            Thread t1 = new Thread(obj.F1); //~1MB
            Thread t2 = new Thread(obj.F2);
            Thread t3 = new Thread(obj.F3);
            t1.Start();t2.Start();t3.Start();
        }
    }
}
