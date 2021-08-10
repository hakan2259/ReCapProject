using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2013,DailyPrice=3000,Description="Chevrolet Camaro"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2021,DailyPrice=1000,Description="BMW 520i Sport Line"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2015,DailyPrice=7000,Description="BMW i8 Premium Techno"},
                new Car{Id=4,BrandId=3,ColorId=4,ModelYear=2016,DailyPrice=775,Description="Volkswagen Passat 1.6 TDI BlueMotion Comfortline"},
                new Car{Id=5,BrandId=3,ColorId=4,ModelYear=2014,DailyPrice=500,Description="Volkswagen Golf 1.6 TDI BlueMotion Highline"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car carToGetById = _cars.SingleOrDefault(c => c.Id == id);
            return carToGetById;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}

