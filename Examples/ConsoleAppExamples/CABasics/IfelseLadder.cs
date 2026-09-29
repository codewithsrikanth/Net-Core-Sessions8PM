using System;

namespace CABasics
{
    class IfelseLadder
    {
        static void Main()
        {
            double num1, num2, result;
            char op;

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Operator (+,-,*,/,%):");
            op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (op == '+')
            {
                result = num1 + num2;
                Console.WriteLine("Result is: " + result);
            }
            else if (op == '-')
            {
                result = num1 - num2;
                Console.WriteLine("Result is: " + result);
            }
            else if (op == '*')
            {
                result = num1 * num2;
                Console.WriteLine("Result is: " + result);
            }
            else if (op == '%')
            {
                result = num1 % num2;
                Console.WriteLine("Result is: " + result);
            }
            else if (op == '/')
            {
                result = num1 / num2;
                Console.WriteLine("Result is: " + result);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}
