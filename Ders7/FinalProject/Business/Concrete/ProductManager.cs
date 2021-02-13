using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        //private InMemoryProductDal inMemoryProductDal;

        public ProductManager(IProductDal productDal)//Dependency injection
        {
            _productDal = productDal;
        }



        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 2)
            {
                return  new ErrorResult("Ürün ismi min 2 karakter olmalıdır")
            }


            //business codes (Eğer gibi kodlar ürünü eklemek için gerekli şartlar)
            _productDal.Add(product);

            return new Result(true,"Ürün eklendi");
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductId== productId);
        }

    }


    
}
