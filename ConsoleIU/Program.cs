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
            //CarTest();
            //BrandTest();
            //ColorTest();


            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Car's Details :" + "\n" + car.BrandName + "\n" + car.ColorName + "\n" + car.DailyPrice + "\n" + car.CarName + "\n");
            }
          

            Console.ReadKey();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetColorId(4).ColorName);

            colorManager.Add(new Color { ColorName = "Brown" });
            colorManager.Delete(new Color { ColorId = 3 });
            colorManager.Update(new Color { ColorId = 4, ColorName = "Brown" });



            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("Color Id :" + color.ColorId + "---->" + "Color Name :" + color.ColorName);
            }
        }


        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetBrandId(2).BrandName);           

            brandManager.Add(new Brand { BrandName = "Audi" });
            brandManager.Delete(new Brand { BrandId = 3 });
            brandManager.Update(new Brand { BrandId = 2, BrandName = "Renault" });


            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("Brand Id :" + brand.BrandId + "---->" + "Brand Name :" + brand.BrandName);
            }
        }


        private static void CarTest()
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

            carManager.Delete(new Car { CarId = 2 });
            carManager.Update(new Car { CarId = 3, BrandId = 4, ColorId = 5, ModelYear = 2018, DailyPrice = 1300, Description = "...." });


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

            foreach (var car in carManager.GetByDailyPrice(1000, 8000))
            {
                Console.WriteLine("Car Id :" + car.CarId + " --> " + "Daily Price :" + car.DailyPrice);
            }
        }
    }
}
