using System;
using System.Collections.Generic;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int[]> arr = new MyList<int[]>();
            int[] a = new int[] { 10, 20, 30, 40 }; 
            int[] b = new int[] { 100, 200, 300}; 
            int[] c = new int[] { 11, 22, 33, 44, 55}; 

            arr.Add(a);
            arr.Add(b);
            arr.Add(c);
                Console.WriteLine("{0}", arr);
           
        }
    }
}
