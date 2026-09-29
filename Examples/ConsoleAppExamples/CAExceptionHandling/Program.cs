using System;

namespace CAExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Logic where there is a possibility of getting execptions 
                Console.WriteLine("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Num2:
                Console.WriteLine("Enter Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Second number can't be zero");
                    goto Num2;
                }
                int res = num1 / num2;
                Console.WriteLine("Result is: " + res);
            }
            catch(Exception ex)
            {
                //It is used to catch the exception
                Console.WriteLine($"Error Message: {ex.Message} and StackTrace: {ex.StackTrace}");
            }
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                //This block will get execute always
                Console.WriteLine("This will get execute always");
            }            
        }
    }
}
