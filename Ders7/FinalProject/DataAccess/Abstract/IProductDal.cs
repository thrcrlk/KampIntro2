using Core.DataAccess;
using Entities.Concrete;//Entities katmanını DataAccess katmanında kullanılması için tanımlamak
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code Reafactoring