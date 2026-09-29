using System;
using System.Collections.Generic;

namespace CALoopsExamples
{
    class Example5
    {
        static void Main()
        {
            //int[] marks = new int[5] {10,20,30,40,50 };
            //int[] marks = new int[] {10,20,30,40,50,60};
            //int[] marks = new int[4];
            //marks = new int[4] {12,3,45,5 };

            int[] marks = { 85,90,78,92,88 };

            //Console.WriteLine(marks[0]);
            //Console.WriteLine(marks[1]);
            //Console.WriteLine(marks[2]);
            //Console.WriteLine(marks[3]);
            //Console.WriteLine(marks[4]);
            //for (int i = 0; i < marks.Length; i++)
            //{               
            //    Console.Write(marks[i]+"  ");
            //}
            //int i = 0;
            //while(i< marks.Length)
            //{
            //    Console.Write(marks[i] + "  ");
            //    i++;
            //}


            Console.WriteLine("Elements of array are: ");
            //IEnumerator<int> iterator = (IEnumerator<int>)marks.GetEnumerator();
            //while (iterator.MoveNext())
            //{
            //    Console.WriteLine(iterator.Current);
            //}


            foreach (int x in marks)
            {
                Console.Write(x + "  ");
            }

        }
    }
}
