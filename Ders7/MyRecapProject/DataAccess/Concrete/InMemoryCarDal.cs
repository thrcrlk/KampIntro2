using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=10,ModelYEar=1998,DailyPrice=45000,Description="Very cheap from its first owner" },
                new Car{CarId=3,BrandId=3,ColorId=10,ModelYEar=2020,DailyPrice=100000,Description="Very celar from its second owner" },
                new Car{CarId=4,BrandId=3,ColorId=10,ModelYEar=1988,DailyPrice=50000,Description="Ypu can reach me via +915551554545 " },
                new Car{CarId=5,BrandId=22,ColorId=10,ModelYEar=2021,DailyPrice=350000,Description="It's very fresh model" }
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUptade = carToUptade = _cars.SingleOrDefault(c => c.CarId == car.CarId)
;
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;

        }

        public List<Car> GetAllById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }


    }
}
