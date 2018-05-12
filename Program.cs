using System;
using System.Collections.Generic;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> arr = new MyList<int>();
            int[] a = new int[] { 10, 20, 30, 40 }; 
            int[] b = new int[] { 100, 200, 300}; 
            int[] c = new int[] { 11, 22, 33, 44, 55}; 

            arr.Add2(a);
            arr.Add2(b);
            arr.Add2(101, 202, 303, 404, 505);

            foreach (int[] mass in arr)
            {
                foreach (var item in mass)
                {
                    Console.Write(" {0}",item);
                }
                Console.WriteLine();
            }
            
            arr.Remove(2);
            
            Console.WriteLine(arr.Count);
          

        }
    }
}
