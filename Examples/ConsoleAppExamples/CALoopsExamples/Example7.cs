using System;

namespace CALoopsExamples
{
    class Example7
    {
        static void Main()
        {
            int[,] arr = new int[3, 4] { {12,23,45,34 },{34,54,56,77 },{ 65,67,89,98} };
            for(int r = 0; r < 3; r++)
            {
                for(int c = 0; c < 4; c++)
                {
                    Console.Write(arr[r, c] + " ");
                }
                Console.WriteLine();
            }

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
