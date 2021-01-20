using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Tahir", "Hasan", "Semih", "İbrahim" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];//İsimler stack kısmında aynıdır fakar Heap adresi artık farklıdır ve boştur.
            //isimler[4] = "Ahmet";
            //Console.WriteLine(isimler[2]);// 2 artık boştur. Çünkü string yeniden tanımlanmıştır. Bu sebeple array ler daha sonradan güncellenecek bölümlerde kullanılmamalıdır.
            //Console.WriteLine(isimler[4]);

            //Koleksiyonlar
            List<string> isimler2 = new List<string> { "Tahir", "Hasan", "Semih", "İbrahim" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");//yeni girdiyi 5. eleman olarak ekler
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            

        }
    }
}
//ctrl+k ctrl+c bütün seçilen kod bloğunu command yorum yapar.
//ctrl+k ctrl+u ucommanda