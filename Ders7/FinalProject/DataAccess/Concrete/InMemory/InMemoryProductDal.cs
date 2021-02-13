using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:IProductDal
    {

        List<Product> _products;//class içinde fakat metot içinde olmayan değişkenlere _değişken eklenir.
        public InMemoryProductDal() //construtor  (ctor-tab-tab)
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Mouse",UnitPrice=100,UnitsInStock=15 },
            new Product { ProductId = 2, CategoryId = 2, ProductName = "Klavye", UnitPrice = 500, UnitsInStock = 40 },
            new Product { ProductId = 3, CategoryId = 3, ProductName = "Monitör", UnitPrice = 1000, UnitsInStock = 5 },
            new Product { ProductId = 4, CategoryId = 4, ProductName = "Ekran Kartı", UnitPrice = 1500, UnitsInStock = 10 },
            new Product { ProductId = 5, CategoryId = 5, ProductName = "İşlemci", UnitPrice = 2500, UnitsInStock = 10 }
            };//Uygulama ilk çalıştığında tanımlanacak
            
        
        
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LING--Languange Integrated Query 
            Product productToDelete= null; // new Product() olarak tanımlarsak bellekte foreach te yer tutar.
           
            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); // _product içindeki Id numarasını p değişkeni ile arar ve bulursa atar. Foreach in tek satır halidir.
            //ProductId eşsiz olmalıdır aksi halde SingleOrDefault hata verir.
            // Yani ProductId her ğrğn için özel olmalıdır.
            _products.Remove(productToDelete);//List içerisinden belirtilen referansı adresini temizler
        }

        public List<Product> GetAll()
        {
            return _products;
        }

       

        public void Update(Product product)
        {
            Product productToUpdate  = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();             
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetailDtos()
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
