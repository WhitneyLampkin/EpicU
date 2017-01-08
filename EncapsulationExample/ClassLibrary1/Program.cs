using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car() { MyProperty = 7 };
            //Notice that we cannot get to CreateDisplay.
            //We can only access it through the public interface Display();
            car.Display();
            Console.ReadLine();
        }
    }

    class Car
    {
        private int myVar;

        public int MyProperty
        {
            //We can encapsulate/hide myVar with the following getters/setters
            get
            { //Only reveal to users with certain rights in the system.
              //if (User.Role = "Admin")
                return myVar;
            }
            set
            {
                //Here we can check to see if this value makes sense with validation.
                //if (value < 0 || > 2000)
                myVar = value;
            }
        }
        
        public void Display()
        {
            var value = CreateDisplay();
            Console.WriteLine(value);
        }

        //Private Helper Method used only in teh car class.
        private string CreateDisplay()
        {
            return $"Car: {myVar}";
        }

        //public int MyOtherProperty { get; set; }

    }
}
