using DataAccess.Abstruct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> { 
                new Car{ Id=1,BrandId=1,ColorId=2,DailyPrice=100000,Description="hahhaskka",ModelYear=2015},
                new Car{ Id=2,BrandId=5,ColorId=3,DailyPrice=170000,Description="hahhaskka",ModelYear=2018},
                new Car{ Id=3,BrandId=1,ColorId=2,DailyPrice=60000,Description="hahhaskka",ModelYear=2012},
                new Car{ Id=4,BrandId=4,ColorId=1,DailyPrice=800000,Description="hahhaskka",ModelYear=2021}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _car.SingleOrDefault(p => p.Id==car.Id);
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
