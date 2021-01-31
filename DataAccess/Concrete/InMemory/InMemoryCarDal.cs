using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal :ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=125,Description="2000 Model Polo"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2001,DailyPrice=100,Description="2001 Model Fabia"},
                new Car{Id=3,BrandId=3,ColorId=3,ModelYear=2002,DailyPrice=50,Description="2002 Model İbiza"},
                new Car{Id=4,BrandId=4,ColorId=4,ModelYear=2010,DailyPrice=250,Description="2010 Model Fiesta"},
                new Car{Id=5,BrandId=5,ColorId=5,ModelYear=2020,DailyPrice=325,Description="2020 Model Jazz"},
                new Car{Id=6,BrandId=6,ColorId=6,ModelYear=2021,DailyPrice=398,Description="2021 Model Corsa"}
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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToDelete.Id = car.Id;
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.ModelYear = car.ModelYear;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.Description = car.Description;





        }
    }
}
