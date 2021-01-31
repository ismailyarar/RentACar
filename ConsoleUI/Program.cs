using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            carManager.Add(new Car { Id = 7, BrandId = 7, ColorId = 7, DailyPrice = 169, ModelYear = 2015, Description = "2015 Model Yaris" });
            foreach (var car in carManager.GetById(7))
            {
                Console.WriteLine(car.Description);
            }

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}
