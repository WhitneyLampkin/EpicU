using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House();

            //var room = new House.Room() { Name = "Kitchen" };
            //house.Rooms.Add(room);
            house.AddRoom("Kitchen");

            house.Display();

            //IMPORTANT
            house = null;

            //The following line of code will destroy the house and the rooms.
            Console.WriteLine("Destroyed house...");


            //The following line of code will not display the rooms because the rooms are now gone too.
            //Strangely, the kitchen is still here. 
            //To change this we need 
            //room.Display();

            //This rightfully throws an exception since the house is destroyed, 
            //so are the rooms.
            Console.WriteLine(house.RoomCount());

            Console.ReadLine();
        }
    }

    class House
    {
        protected List<Room> Rooms { get; set; }
        public House()
        {
            Rooms = new List<Room>();
            var room1 = new Room() { Name = "Bedroom 1" };
            var room2 = new Room() { Name = "Bedroom 2" };
            var room3 = new Room() { Name = "Bedroom 3" };

            Rooms.Add(room1);
            Rooms.Add(room2);
            Rooms.Add(room3);
        }

        public void AddRoom(string name)
        {
            var room = new Room() { Name = name };
            Rooms.Add(room);
        }

        public int RoomCount()
        {
            return Rooms.Count();
        }

        public void Display()
        {
            foreach (var room in Rooms)
            {
                room.Display();
            }
        }

        //Notice that this Room class is inside of the House class.
        //Denoting that there is a relationship between the two.
        //To get this to work as a true composition example, the public 
        //keyword has to be changed to protected. 
        //Protected members are only accessible within its class and derived
        //instances. Therefore, it won't be accessible to the program class.
        protected class Room
        {
            public string Name { get; set; }

            public void Display()
            {
                Console.WriteLine($"Room: {Name}");
            }
        }
    }
}
