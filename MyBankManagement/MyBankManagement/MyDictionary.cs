using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] items;

        public MyDictionary() { items = new T[0]; }

        public void Add(T item)
        {
            T[] MytempArray = items[];
            items = new T[items.Length + 1];
            for (int i = 0; i < MytempArray.Length; i++)
            {
                items[i] = MytempArray[i];
            }
            items[items.Length - 1] = item;

        }

        public int Length
        {
            get { return items.Lenght}
        }

        public T[] items
        {
            get { return items.Length; }
        }





    }
}
