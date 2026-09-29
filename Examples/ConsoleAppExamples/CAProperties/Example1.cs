using System;

namespace CAProperties
{
    class Arthematic
    {
        int num1, num2, result;
        //Write-Only
        public int Num1
        {
            set { num1 = value; }
        }
        //Write-Only
        public int Num2
        {
            set { num2 = value; }
        }
        //Read-Only
        public int Result
        {
            get { return result; }
        }
        public void Add()
        {
            result = num1 + num2;
        }

    }
    class Example1
    {
        static void Main(string[] args)
        {
            Arthematic obj= new Arthematic();
            obj.Num1 = 100;
            obj.Num2 = 200;
            obj.Add();
            Console.WriteLine("Addition is: "+obj.Result);
        }
    }
}
