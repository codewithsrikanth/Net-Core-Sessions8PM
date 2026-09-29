using System;

namespace CAAccessModifiers1
{
    public class First
    {
        void F1()
        {
            Console.WriteLine("This is Private Method");
        }
        protected void F2()
        {
            Console.WriteLine("This is Protected Method");
        }
        internal void F3()
        {
            Console.WriteLine("This is Internal Method");
        }
        protected internal void F4()
        {
            Console.WriteLine("This is Protected Internal Method");
        }
        private protected void F5()
        {
            Console.WriteLine("This is Private Protected Method");
        }
        public void F6()
        {
            Console.WriteLine("This is Public Method");
        }

        static void Main(string[] args)
        {
            First obj = new First();
            obj.F1();
            obj.F2();
            obj.F3();
            obj.F4();
            obj.F5();
            obj.F6();

        }
    }
}
