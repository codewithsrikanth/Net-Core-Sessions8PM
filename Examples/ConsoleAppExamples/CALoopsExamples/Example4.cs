using System;

namespace CALoopsExamples
{
    class Example4
    {
        static void Main(string[] args)
        {
            for (int r = 1; r < 10; r++)
            {
                for(int c = 1; c <= r; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
