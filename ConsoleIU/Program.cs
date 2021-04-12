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
            //CarDetailsTest();
            //CustomerTest();

            Console.ReadKey();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            Customer customer1 = new Customer();
            customer1.UserId = 1;
            customer1.CompanyName = "XY Company";
            customerManager.Add(customer1);

            Customer customer2 = new Customer();
            customer2.UserId = 2;
            customer2.CompanyName = "AB Company";
            customerManager.Add(customer2);

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Car's Details :" + "\n" + car.BrandName + "\n" + car.ColorName + "\n" + car.DailyPrice + "\n" + car.CarName + "\n");
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetColorId(4).Data.ColorName);

            colorManager.Add(new Color { ColorName = "Brown" });
            colorManager.Delete(new Color { ColorId = 3 });
            colorManager.Update(new Color { ColorId = 4, ColorName = "Brown" });



            foreach (var color in colorManager.GetAll().Data)
            {           
                Console.WriteLine("Color Id :" + color.ColorId + "/" + " Color Name :" + color.ColorName);
            }

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetBrandId(2).Data.BrandName);

            brandManager.Add(new Brand { BrandName = "Audi" });
            brandManager.Delete(new Brand { BrandId = 3 });
            brandManager.Update(new Brand { BrandId = 2, BrandName = "Renault" });


            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("Brand Id :" + brand.BrandId + "---->" + "Brand Name :" + brand.BrandName);
            }


            var result = brandManager.Add(new Brand { BrandName = "X"});
            if(result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
          
        }


        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var add = carManager.Add(new Car
            {
                ColorId = 7,
                BrandId = 7,
                ModelYear = 2019,
                DailyPrice = 4800,
                Description = "........."
            });

            Console.WriteLine(add.Message);

            var delete = carManager.Delete(new Car { Id = 2 });
            Console.WriteLine(delete.Message);
            
            var update = carManager.Update(new Car { Id = 3, BrandId = 4, ColorId = 5, ModelYear = 2018, DailyPrice = 1300, Description = "...." });
            Console.WriteLine(update.Message);


            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Car Id:" + car.Id + "\nBrand Id :" + car.BrandId + "\nColor Id :" + car.ColorId +
                                  "\nCar Daily Price :" + car.DailyPrice + "\nDescription :" + car.Description + "\n**********");
            }


            foreach (var car in carManager.GetCarsByBrandId(5).Data)
            {
                Console.WriteLine(car.DailyPrice);
            }


            foreach (var car in carManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine("Car Id :" + car.Id + " --> " + "Brand Id:" + car.BrandId);
            }

            foreach (var car in carManager.GetByDailyPrice(1000, 8000).Data)
            {
                Console.WriteLine("Car Id :" + car.Id + " --> " + "Daily Price :" + car.DailyPrice);
            }

        }
    }
}
