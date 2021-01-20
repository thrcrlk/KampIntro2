using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        //Metotun içerisine sınıf değişkeni girilmesi için kullalır. Teker teker tüm sınıf alt değişkenlerini tanımlamamak için 
      
        

        
        public void Add(Product product)  
        {
            Console.WriteLine(product.Productname +" "+ "Eklendi");
         }

        public void Uptade(Product product)
        {
            Console.WriteLine(product.Productname +" "+ "Güncellendi");
        }

    }
}
