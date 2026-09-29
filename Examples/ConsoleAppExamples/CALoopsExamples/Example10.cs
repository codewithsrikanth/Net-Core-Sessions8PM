using System;

namespace CALoopsExamples
{
    class Example10
    {
        static void Main(string[] args)
        {
            int[] marks = {85,12,43,98,13,46,12,65,88 };
            Console.WriteLine("Elements of array are: ");
            foreach (int i in marks) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Sort(marks);
            foreach (int i in marks)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Reverse(marks);
            foreach (int i in marks)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int index = Array.IndexOf(marks, 43);
            Console.WriteLine("Index value is: "+index);
            int lastIndex = Array.LastIndexOf(marks, 12);
            Console.WriteLine("Last Index is: "+lastIndex);

            int[] copyArray = new int[marks.Length];
            Array.Copy(marks, copyArray, marks.Length);
            foreach (int i in copyArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Clear(copyArray, 2, 3);
            foreach (int i in copyArray)
            {
                Console.Write(i + " ");
            }
            bool result = Array.Exists(copyArray, x => x > 200);
            Console.WriteLine();
            Console.WriteLine(result);

            
        }
    }
}
