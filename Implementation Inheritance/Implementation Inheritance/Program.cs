using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_Inheritance
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

            car.Display();
            Console.WriteLine();
            Console.ReadLine();

            var suv = new SUV()
            {
                Make = "GMC",
                Model = "Yukon",
                Year = 2013,
                DriveMechanism = "4 wheel drive"
            };

            suv.Display();

            Console.WriteLine();
            Console.ReadLine();
        }
     }

    public class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Display()
        {
            Console.Write($"Auto: {Make} {Model} {Year}");
        }
    }

    public class SUV : Automobile
    {
        public string DriveMechanism { get; set; }

        public new void Display()
        {
            Console.Write($"SUV: {Make} {Model} {Year} {DriveMechanism}");
        }
    }

}
