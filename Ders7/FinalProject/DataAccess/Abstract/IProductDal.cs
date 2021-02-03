using Entities.Concrete;//Entities katmanını DataAccess katmanında kullanılması için tanımlamak
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IProdcutDal:IEntityRepository<Product>
    {

    }
}
