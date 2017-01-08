using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Automobile()
            {
                Make = "Toyota",
                Model = "4Runer",
                Year = 2010
            };

            //car.Display();
            Print(car);
            Console.ReadLine();

            var suv = new SUV()
            {
                Make = "GMC",
                Model = "Yukon",
                Year = 2013,
                DriveMechanism = "4 wheel drive"
            };

            //suv.Display();
            Print(suv);
            Console.ReadLine();
        }

        private static void Print(Automobile auto)
        {
            auto.Display();
        }
    }

    public class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //The virtual keyword is used to modify a method, property, indexer, 
        //or event declaration and allow for it to be overridden in a derived
        //class. For example, this method can be overridden by any class
        //that inherits it:
        public  virtual void Display()
        {
            Console.Write($"Auto: {Make} {Model} {Year}");
        }
    }

    public class SUV : Automobile
    {
        //Encapsulation isn't used here...keep in mind that it's 
        //not always necessary.
        public string DriveMechanism { get; set; }

        public override void Display()
        {
            Console.Write($"SUV: {Make} {Model} {Year} {DriveMechanism}");
        }
    }
}
