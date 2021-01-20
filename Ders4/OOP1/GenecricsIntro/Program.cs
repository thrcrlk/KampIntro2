using System;

namespace GenecricsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList <string> isimler = new MyList<string>();//Generic Class değişkeni tanımalama
            isimler.Add("Tahir");
            Console.WriteLine(isimler.Lenght);
            isimler.Add("Hasan");
            isimler.Add("Damla");
            isimler.Add("Mehmet");
            isimler.Add("Ahmet");
            isimler.Add("Semih");
            Console.WriteLine(isimler.Lenght);
          

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
