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


      
        public void Add2(params T[] value)
        {
            list.Add(value);
        }
        public void Remove(int index)
        {
            list.RemoveAt(index);
          
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
      
    } 
}
