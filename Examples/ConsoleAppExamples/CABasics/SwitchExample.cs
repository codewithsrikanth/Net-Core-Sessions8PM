using System;
using System.Threading;

namespace CABasics
{
    class SwitchExample
    {
        static void Main()
        {
            Start:
            double num1, num2, result = 0;
            char op;

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Operator (+,-,*,/,%):");
            op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator, retry again");
                    goto Start;

            }
            Console.WriteLine("Result is: "+result);

        }
    }
}
