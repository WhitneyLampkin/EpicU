using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            {
                Make = "Ford",
                Model = "Mustang GT"
            };

            var book = new Book()
            {
                Title = "Some Title",
                Author = "Some Author"
            };

            var shirt = new Shirt()
            {
                Size = "Medium",
                Price = 12.98
            };

            DisplayYourself(car);
            DisplayYourself(book);
            DisplayYourself(shirt);

            //DisplayCar(car);
            //DisplayBook(book);

            Console.ReadLine();
        }

        static void DisplayYourself(IDisplayable myObject)
        {
            //Any objected passed into this method must have a Display() method implemented.
            myObject.Display();
        }

        //static void DisplayCar(Car car)
        //{
        //    Console.WriteLine($"Car: {car.Make} {car.Model}");
        //}

        //static void DisplayBook(Book book)
        //{
        //    Console.WriteLine($"Book: {book.Author} {book.Title}");
        //}
    }

    public interface IDisplayable
    {
        void Display();
    }

    public class Car : IDisplayable
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void Display()
        {
            Console.WriteLine($"Car: {Make} {Model}");
        }
    }

    public class Book : IDisplayable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void Display()
        {
            Console.WriteLine($"Book: {Author} {Title}");
        }
    }

    public class Shirt : IDisplayable
    {
        public string Size { get; set; }
        public double Price { get; set; }

        public void Display()
        {
            Console.WriteLine($"Shirt: {Size} ${Price}");
        }
    }
}
