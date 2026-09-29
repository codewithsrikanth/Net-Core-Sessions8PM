using System;

namespace CADelegates
{
    //Create a delegate
    public delegate void DelAdd(int a, int b);
    class Program
    {
        static void Add(int x,int y)
        {
            Console.WriteLine("Addition is: "+(x+y));
        }
        static void Main(string[] args)
        {
            //Instatiate a delegate
            DelAdd objD = new DelAdd(Add);
            //Invoking a delegate
            objD(100, 200);
        }
    }
}
