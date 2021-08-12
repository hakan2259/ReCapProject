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
            //CarTest();

            CarManager carManager = new CarManager(new EfCarDal());

            //Console.WriteLine(carManager.GetById(1).Description);

            //CarInsert(carManager);

            //CarUpdate(carManager);

            //CarDelete(carManager);

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void CarDelete(CarManager carManager)
        {
            carManager.Delete(new Car
            {
                Id = 3002
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " / " + car.Description);
            }
        }

        private static void CarUpdate(CarManager carManager)
        {
            carManager.Update(new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 325
            });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " / " + car.DailyPrice);
            }
        }

        private static void CarInsert(CarManager carManager)
        {
            carManager.Add(new Car
            {
                BrandId = 4,
                ColorId = 1,
                DailyPrice = 800,
                ModelYear = 2020,
                Description = "218i Gran Coupe First Edition Sport Line"
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void CarTest()
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
