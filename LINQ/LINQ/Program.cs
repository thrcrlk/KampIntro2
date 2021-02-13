using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Category> categories = new List<Category>
            {
                new Category {CategoryId=1,CategoryName="PC"},
                new Category {CategoryId=2,CategoryName="Telefon"}
            };
            List<Product> products = new List<Product>
            {
                new Product {ProdcutId=1,CategoryId=1,ProductName="Acer",QuantityPerUnit="22",UnitPrice=10000,UnitsInStock=100},
                new Product {ProdcutId=2,CategoryId=1,ProductName="Dell",QuantityPerUnit="SSS",UnitPrice=2000,UnitsInStock=120},
                new Product {ProdcutId=3,CategoryId=2,ProductName="Iphone",QuantityPerUnit="2",UnitPrice=10000,UnitsInStock=1000},
                new Product {ProdcutId=4,CategoryId=2,ProductName="Samsung",QuantityPerUnit="22",UnitPrice=10000,UnitsInStock=100},
                new Product {ProdcutId=5,CategoryId=1,ProductName="Acer22",QuantityPerUnit="1",UnitPrice=15500,UnitsInStock=1}
            };


            var result = products.Where(p => p.UnitPrice > 1000 && p.UnitsInStock > 100);
            var result2 = products.Where(p => p.UnitPrice > 1000 && p.UnitsInStock > 50).ToList();


            foreach (var item in result2)
            {
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.UnitPrice);

            }


        }


        class Product
        {
            public int ProdcutId { get; set; }
            public string ProductName { get; set; }
            public int CategoryId { get; set; }
            public string QuantityPerUnit { get; set; }
            public int UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }

        }

    }
}
