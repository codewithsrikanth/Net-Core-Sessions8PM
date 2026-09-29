using System;

namespace CAProperties
{
    class Bank
    {
        int accNo;
        int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 18 || value > 60)
                    throw new ArgumentException("Age must be in between 18 to 60");
                age = value; 
            }
        }

        public int AccNo
        {
            set { accNo = value; }
            get { return accNo; }
        }

        //public void SetAccNo(int accNo)
        //{
        //    this.accNo = accNo;
        //}
        //public int GetAccNo() 
        //{
        //    return accNo;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new Bank();
            //obj.SetAccNo(1234567);
            //Console.WriteLine(obj.GetAccNo());
            obj.AccNo = 1234567;
            Console.WriteLine(obj.AccNo);
            obj.Age = 0;
            Console.WriteLine(obj.Age);
        }
    }
}
