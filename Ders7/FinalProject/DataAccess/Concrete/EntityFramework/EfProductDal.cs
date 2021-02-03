using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    //NuGet ortak yapıların bulunduğu portal
    //EntityFramework burada bulunabilir

    public class EfProductDal : IProdcutDal
    {
        public void Add(Product entity)
        {
            //IDisposable pattern implemantation of c#
            //Garbage Collectore işi bittiği gibi kendini temizleme yapmasını belirten bir metot
            using (NorthwindContext context = new NorthwindContext())
            {
                //var değişken için tanımlama yapılmıyor int,array vb. gibi 
                //karşısında ne gelirse onun tanımını kabul eder
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //var değişken için tanımlama yapılmıyor int,array vb. gibi 
                //karşısında ne gelirse onun tanımını kabul eder
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //Turnery operatoru if else alternatifi
                return filter == null 
                    ? context.Set<Product>().ToList()
                    :context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //var değişken için tanımlama yapılmıyor int,array vb. gibi 
                //karşısında ne gelirse onun tanımını kabul eder
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }

}
