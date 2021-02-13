using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.IEntityFramework
{
    class EFCarDal : ICarDal
    {
        public void Add(Car entity)
        {
           using(MyDataBaseContext context = new MyDataBaseContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }


        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList() 
                    : context.Set<Car>().Where(filter).ToList();

            }
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
