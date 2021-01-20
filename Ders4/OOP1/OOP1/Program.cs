using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.Productname = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 50;

            //PascalCase      camelCase
            //ProductName     productName
            //C# is case sensitivi.(Büyük-küçük hard duyarlıdır.) 
            
            Product product2 = new Product { Id = 2, CategoryId = 5,Productname="Kalem",UnitPrice=35,UnitsInStock=100 }; //Yeni ürün sınıf değişkeni tanımlama şekli

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
