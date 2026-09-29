using System;

namespace CALoopsExamples
{
    class Example8
    {
        static void Main()
        {
            int[,] sales =
            {
                {120,345,543 },
                {987,647,282 },
                {876,456,837 }
            };

            Console.WriteLine("Eleements of Multi Dimentional Array are: ");
            for (int i = 0; i < sales.GetLength(0); i++) 
            {
                Console.WriteLine("Product "+(i+1)+": ");
                for (int j = 0; j < sales.GetLength(1); j++) 
                {
                    Console.WriteLine(sales[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
