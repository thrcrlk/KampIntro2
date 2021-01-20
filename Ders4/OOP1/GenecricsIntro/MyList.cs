using System;
using System.Collections.Generic;
using System.Text;

namespace GenecricsIntro
{
    //Generic class tanımlama  Mylist<T>
    class MyList<T>//T type ın kısaltması elemanın türünü belirtir. 
    {
        T[] items;
        //COnstructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//items in referansı tempArray a aktarılıyor. Bu sayede eski elemanların referans numarası tutuluyor.
            items = new T[items.Length+1];//Dizinin eleman sayısını 1 artırır.
            for(int i=0; i< tempArray.Length;i++)
            {
                items[i] = tempArray[i];//temparray de tutulan ref değelere tekrar ana dizite aktarılıyor.
            }

            items[items.Length - 1] = item;// son index e (yani yeni açılan hafıza alanına) girilen değer atanır.
        
        }

        public int Lenght
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }

    }
}
