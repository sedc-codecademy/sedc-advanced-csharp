using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingG3
{
    class Program
    {
        static void Main(string[] args)
        {
            var payed = new PayedParking<string>(100, 3);

            payed.Park("Audi");
            payed.Park("Ferrari");

            Console.WriteLine(payed.OccupiedPlaces);
            Console.WriteLine(payed.FreePlaces);

            payed.Park("BMW");
            payed.Park("Mercedes");

            Console.WriteLine(payed);
            return;
            TestParking<string>(20, new List<string> { "Audi","Mercedes","Toyota","Ferrari","Yugo","Ford","BMW","Opel"});
            TestParking<int>(50, new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        static void TestParking<T>(int capacity, List<T> values)
        {
            Console.WriteLine($"--- {typeof(T)} parking with {capacity} capacity");
            var parking = new Parking<T>(capacity);
            try
            {
                parking.LeaveParking();
                Console.WriteLine("YOU SHOULD NOT SEE ME");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            parking.Park(values[0]);
            parking.Park(values[1]);
            parking.Park(values[2]);

            Console.WriteLine($"{parking.OccupiedPlaces} should be 3");

            var result = parking.LeaveParking();
            Console.WriteLine($"result is {result}");
            result = parking.LeaveParking();
            Console.WriteLine($"result is {result}");

            Console.WriteLine($"{parking.OccupiedPlaces} should be 1");

            parking.Park(values[3]);
            parking.Park(values[4]);
            parking.Park(values[5]);

            Console.WriteLine($"{parking.OccupiedPlaces} should be 4");

            parking.OccupiedPlaces = 12;
            Console.WriteLine($"{parking.OccupiedPlaces} should be 12");

            try
            {
                parking.OccupiedPlaces = 2;
                Console.WriteLine("YOU SHOULD NOT SEE ME");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                parking.OccupiedPlaces = 200;
                Console.WriteLine("YOU SHOULD NOT SEE ME");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            parking.LeaveParking();
            Console.WriteLine($"{parking.OccupiedPlaces} should be 11");

            parking.LeaveParking();
            Console.WriteLine($"{parking.OccupiedPlaces} should be 10");

            parking.LeaveParking();
            Console.WriteLine($"{parking.OccupiedPlaces} should be 9");

            parking.FreePlaces = 8;

            Console.WriteLine(parking);
            Console.WriteLine(parking.Capacity);
        }
    }
}
