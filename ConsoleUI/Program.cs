using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /*carManager.Add(new Car
            {
                BrandId = 14,
                ColorId = 1,
                ModelYear = 2015,
                DailyPrice = 330,
                Description = "V40 1.6 D R-Design"
            });*/

            foreach (var car in carManager.GetCarsByBrandId(14))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("----------------------");
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
