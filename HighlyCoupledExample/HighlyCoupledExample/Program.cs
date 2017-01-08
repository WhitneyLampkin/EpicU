using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighlyCoupledExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var carPersistence = new CarPersistenceToFile();
            var carPersistence = new CarPersistenceToOtherFile();

            var car = new Car(carPersistence)
            {
                Make = "GMC",
                Model = "Yukon",
                Year = 2016
            };
            car.Save();

            Console.Write("Finished!");
        }

        //Domain Object: Car
        class Car
        {
            private readonly ICarPersistence _carPersistence;

            //Now we have dependency injection instead
            public Car(ICarPersistence carPersistence)
            {
                _carPersistence = carPersistence;
            }

            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public void Save()
            {
                //THE PROBLEM IS RIGHT HERE:
                //We need to remove this line of code below and have something inject it in.
                //The Car shouldn't have a direction codependent relationship wtih the Persistence class.
                //var file = new CarPersistenceToFile();

                //Instead use...

                //"NEW is GLUE"
                _carPersistence.SaveCar(this);
            }
        }
        
        interface ICarPersistence
        {
            void SaveCar(Car car);
        }

        class CarPersistenceToFile : ICarPersistence
        {
            public void SaveCar(Car car)
            {
                var record = $"Car Info: {car.Make} {car.Model} {car.Year}";
                string path = @"C:\CouplingExample";
                var di = Directory.CreateDirectory(path);
                File.WriteAllText(@"C:\CouplingExample\Car.txt", record);
            } 
        }

        class CarPersistenceToOtherFile : ICarPersistence
        {
            public void SaveCar(Car car)
            {
                var record = $"Car Info: {car.Make} {car.Model} {car.Year}";
                string path = @"C:\InversionOfControlExample";
                var di = Directory.CreateDirectory(path);
                File.WriteAllText(@"C:\InversionOfControlExample\OtherCar.txt", record);
            }
        }
    }
}
