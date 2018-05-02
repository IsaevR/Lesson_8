using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lesson_8
{
    class MyList<T> 
    {
        T[] List = new T[0];
        public int Length { get { return List.Length; } }


        public void Add(T value)
        {
            T[] newList = new T[List.Length + 1];
            newList[Length] = value;
            
            List = newList;
        }

        public void Remove(int index)
        {
            T[] newList = new T[List.Length - 1];
            
            for (int i = 0; i <= List.Length; i++)
            {
                newList[i] = List[i];
                if (index == i)
                {
                    continue;
                }
                    
            }
            List = newList;
        }
        public int  Count()
        {
            int count = 0;
            for(int i = 0; i < List.Length; i++)
            {
                count++;
            }
            return count;
        }
    } 
}
