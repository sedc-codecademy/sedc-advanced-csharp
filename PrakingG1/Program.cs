using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakingG1
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new Parking<string>(20);

            parking.Park("Ferrari");
            parking.Park("Yugo");
            parking.Park("Opel");
            parking.Park("Toyota");
            parking.Park("Fiat");
            parking.Park("Peugeout");

            var car = parking.LeaveParking();
            car = parking.LeaveParking();
            car = parking.LeaveParking();

            Console.WriteLine("--- Occupied places tests ---");

            var occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 3");

            parking.OccupiedPlaces = 10;
            occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 10");

            parking.Park("Volga");
            occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 11");

            car = parking.LeaveParking();
            occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 10");


            try
            {
                parking.OccupiedPlaces = 2;
                Console.WriteLine("Should not see me");
            }
            catch (Exception)
            {
                Console.WriteLine("Should see me");
            }
            occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 10");

            try
            {
                parking.OccupiedPlaces = 50;
                Console.WriteLine("Should not see me");
            }
            catch (Exception)
            {
                Console.WriteLine("Should see me");
            }
            occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 10");

            Console.WriteLine("--- Free places tests ---");
            var free = parking.FreePlaces;
            Console.WriteLine($"{free} should be 10");
            occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 10");

            car = parking.LeaveParking();
            free = parking.FreePlaces;
            Console.WriteLine($"{free} should be 11");
            occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 9");

            car = parking.LeaveParking();
            free = parking.FreePlaces;
            Console.WriteLine($"{free} should be 12");
            occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 8");

            parking.Park("Seat");
            free = parking.FreePlaces;
            Console.WriteLine($"{free} should be 11");
            occupied = parking.OccupiedPlaces;
            Console.WriteLine($"{occupied} should be 9");

            try
            {
                parking.FreePlaces = 20;
                Console.WriteLine("Should not see me");
            }
            catch (Exception)
            {
                Console.WriteLine("Should see me");
            }
            free = parking.FreePlaces;
            Console.WriteLine($"{free} should be 9");

            try
            {
                parking.FreePlaces = -20;
                Console.WriteLine("Should not see me");
            }
            catch (Exception)
            {
                Console.WriteLine("Should see me");
            }
            free = parking.FreePlaces;
            Console.WriteLine($"{free} should be 9");


            //Console.WriteLine(parking);
        }
    }
}
