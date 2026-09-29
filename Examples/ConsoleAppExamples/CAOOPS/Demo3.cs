using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAOOPS
{
    class Student
    {
        int id;string name;
        public Student(int id,string name)
        {
            Console.WriteLine("This is Constructor");
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {id} and Name: {name}");
        }
        ~Student()
        {
            Console.WriteLine("This is destructor");
        }
    }
    class Demo3
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(10, "Srikanth");
            Student s2 = new Student(20, "Ramesh");
            Student s3 = new Student(30, "Rajesh");

            s1.Display();
            s2.Display();
            s3.Display();

            GC.Collect();

        }
    }
}
