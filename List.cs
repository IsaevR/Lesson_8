using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Lesson_8
{
    class MyList<T> : IEnumerable<T[]>
    {
        private List<T[]> list = new List<T[]>();
        T[] List = new T[0];
        public int Length { get { return List.Length; } }


        //public new void Add(T value)
        //{
        //    T[] newList = new T[List.Length + 1];
        //    newList[Length] = value;

        //    List = newList;
        //}
        public void Add2(params T[] value)
        {
            list.Add(value);
        }
        public void Remove(int index)
        {
            list.RemoveAt(index);
            ////T[] newList = new T[List.Length - 1];
            
            ////for (int i = 0; i <= List.Length; i++)
            ////{
            ////    newList[i] = List[i];
            ////    if (index == i)
            ////    {
            ////        continue;
            ////    }
                    
            //}
            //List = newList;
        }

        public IEnumerator<T[]> GetEnumerator()
        {
            return ((IEnumerable<T[]>)list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int Count { get { return list.Count; } }
        //public new int  Count()
        //{
        //    int count = 0;
        //    for (int i = 0; i < List.Length; i++)
        //    {
        //        count++;
        //    }
        //    return count;
        //}
    } 
}
