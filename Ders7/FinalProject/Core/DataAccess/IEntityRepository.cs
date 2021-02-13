using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{

    //Generic constraint
    //class: reference tip
    //IEntity interface ine ait tüm classlar yazılabilir
    // Yani IEntity veya IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalıdır. Yani IEntity'i implemente eden bir class olabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {

        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T,bool>>filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
 
    }
}
