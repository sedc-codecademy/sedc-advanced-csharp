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
            //var parking = new Parking<string>(5);

            //try
            //{
            //    var empty = parking.LeaveParking();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //parking.Park("Ferrari");
            //parking.Park("Yugo");
            //parking.Park("Opel");
            //parking.Park("Toyota");
            //parking.Park("Fiat");
            //try
            //{
            //    parking.Park("Peugeout");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //var occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} occupied");

            //var car = parking.LeaveParking();
            //car = parking.LeaveParking();
            //car = parking.LeaveParking();
            //Console.WriteLine(parking);

            //Console.WriteLine("--- Occupied places tests ---");

            //var occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 3");

            //parking.OccupiedPlaces = 10;
            //occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 10");

            //parking.Park("Volga");
            //occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 11");

            //car = parking.LeaveParking();
            //occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 10");

            //try
            //{
            //    parking.OccupiedPlaces = 2;
            //    Console.WriteLine("Should not see me");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Should see me");
            //}
            //occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 10");

            //try
            //{
            //    parking.OccupiedPlaces = 50;
            //    Console.WriteLine("Should not see me");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Should see me");
            //}
            //occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 10");

            //Console.WriteLine("--- Free places tests ---");
            //var free = parking.FreePlaces;
            //Console.WriteLine($"{free} should be 10");
            //occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 10");

            //car = parking.LeaveParking();
            //free = parking.FreePlaces;
            //Console.WriteLine($"{free} should be 11");
            //occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 9");

            //car = parking.LeaveParking();
            //free = parking.FreePlaces;
            //Console.WriteLine($"{free} should be 12");
            //occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 8");

            //parking.Park("Seat");
            //free = parking.FreePlaces;
            //Console.WriteLine($"{free} should be 11");
            //occupied = parking.OccupiedPlaces;
            //Console.WriteLine($"{occupied} should be 9");

            //try
            //{
            //    parking.FreePlaces = 20;
            //    Console.WriteLine("Should not see me");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Should see me");
            //}
            //free = parking.FreePlaces;
            //Console.WriteLine($"{free} should be 11");

            //try
            //{
            //    parking.FreePlaces = -20;
            //    Console.WriteLine("Should not see me");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Should see me");
            //}
            //free = parking.FreePlaces;
            //Console.WriteLine($"{free} should be 11");


            var pp = new PayedParking<string>(3, 100);

            pp.Park("Audi");
            pp.Park("Mercedes");
            pp.Park("Toyota");

            var audi = pp.LeaveParking();
            pp.Park("Jeep");

            var mercedes = pp.LeaveParking();
            pp.Park("BMW");

            Console.WriteLine(pp.Balance);
        }
    }
}
