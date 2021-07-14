using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //Sadece simüle etmek için list
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars= new List<Car> {
                new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=900, Description="Ortalama km basina 50 tl yakiyo", ModelYear=2009},
                new Car {Id=2, BrandId=1, ColorId=5, DailyPrice=1500, Description="Ortalama km basina 60 tl yakiyo", ModelYear=2012},
                new Car {Id=3, BrandId=2, ColorId=1, DailyPrice=2000, Description="Ortalama km basina 75 tl yakiyo", ModelYear=2012},
                new Car {Id=4, BrandId=3, ColorId=2, DailyPrice=1750, Description="Ortalama km basina 45 tl yakiyo", ModelYear=2012}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(p=> p.Id == car.Id));
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(p => p.Id == carId);
        }

        public void Update(Car car)
        {
            Car carUpdate=_cars.SingleOrDefault(p=> p.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}
