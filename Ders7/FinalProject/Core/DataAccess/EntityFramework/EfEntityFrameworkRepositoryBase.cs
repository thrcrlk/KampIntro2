using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityFrameworkRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class, IEntity, new()//TEntity nin class ve IEnetity e implement eden bir değişken olması gerekli
        where TContext: DbContext,new()//TContext nin class ve DbContext e implement eden bir değişken olması gerekli

    {

        public void Add(TEntity entity)
        {
            //IDisposable pattern implemantation of c#
            //Garbage Collectore işi bittiği gibi kendini temizleme yapmasını belirten bir metot
            using (TContext context = new TContext())
            {
                //var değişken için tanımlama yapılmıyor int,array vb. gibi 
                //karşısında ne gelirse onun tanımını kabul eder
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                //var değişken için tanımlama yapılmıyor int,array vb. gibi 
                //karşısında ne gelirse onun tanımını kabul eder
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //Turnery operatoru if else alternatifi
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
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
