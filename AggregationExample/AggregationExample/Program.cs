using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Automobile();
            var car2 = new Automobile();
            var car3 = new Automobile();

            var person = new Person() { Name = "Whitney" };

            var fleet = new Fleet();

            fleet.Automobiles.Add(car1);
            fleet.Automobiles.Add(car2);
            fleet.Automobiles.Add(car3);

            fleet.Owner = person;

            foreach (var auto in fleet.Automobiles)
            {
                auto.Display();
            }

            fleet.Owner.Display();

            //IMPORTANT
            fleet = null; //Getting ride of fleet but will the cars or person go away?

            Console.WriteLine("Do the aggregated objects still live?");
            //The answer is yes. The fleet went away but the other objects still assisted.


            car1.Display();
            car2.Display();
            car3.Display();

            person.Display();

            Console.ReadLine();
        }
    }

    class Fleet
    {
        public string Name { get; set; }

        public List<Automobile> Automobiles { get; set; }
        public Person Owner { get; set; }

        public Fleet()
        {
            Automobiles = new List<Automobile>();
        }
    }

    class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Display()
        {
            Console.WriteLine($"Auto: {Make} {Model} {Year}");
        }
    }

    class Person
    {
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"Person: {Name}");
        }
    }
}
