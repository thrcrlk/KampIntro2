using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();//liste döndürür


        List<ProductDetailDto> GetProductDetails();//liste döndürür


        IResult Add(Product product);

        Product GetById(int productId);//Id döndürür

    }
}
