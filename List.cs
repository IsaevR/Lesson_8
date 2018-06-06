using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Lesson_8
{
    // класс MyList имеет тип Generic и наследует интерфейс IEnumerable
    // этот List  может работать с  массивом тип которого определяется пользователем
    
    class MyList<T> : IEnumerable<T[]>
    {
        private List<T[]> list = new List<T[]>();
        T[] List = new T[0];
        public int Length { get { return List.Length; } }


      //Этот  метод записывает массив в List
        public void Add2(params T[] value)
        {
            list.Add(value);
        }
        // Этот метод удаляет элемет по индексу из List
        public void Remove(int index)
        {
            list.RemoveAt(index);
          
        }
        // отображает список массива на консоли
        public IEnumerator<T[]> GetEnumerator()
        {
            return ((IEnumerable<T[]>)list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        // метод который считает количество элементов в List
        public int Count { get { return list.Count; } }
      
    } 
}
