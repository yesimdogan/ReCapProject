using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;


namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {               
                ColorId = 7,
                BrandId = 7,
                ModelYear = 2019,
                DailyPrice = 4800,
                Description = "........."
            });


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id:" + car.CarId + "\nBrand Id :" + car.BrandId + "\nColor Id :" + car.ColorId +
                                  "\nCar Daily Price :" + car.DailyPrice + "\nDescription :" + car.Description + "\n**********");
            }


            foreach (var car in carManager.GetCarsByBrandId(5))
            {
                Console.WriteLine(car.DailyPrice);
            }


            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine("Car Id :" + car.CarId + " --> " + "Brand Id:" + car.BrandId);
            }


            Console.WriteLine("\n");



            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand { BrandName = "Audi" });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("Brand Id :" + brand.BrandId + "---->" + "Brand Name :" + brand.BrandName);
            }




            Console.WriteLine("\n");


            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color {ColorName = "Brown" });
            

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("Color Id :" + color.ColorId + "---->" + "Color Name :" + color.ColorName);
            }


            Console.ReadKey();
        }
    }
}
