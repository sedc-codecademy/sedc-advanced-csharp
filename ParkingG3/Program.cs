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
            TestParking<string>(20, new List<string>
            {
                "Audi",
                "Mercedes",
                "Toyota",
                "Ferarri",
                "Yugo",
                "Ford",
                "BMW",
                "Opel"
            });

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

            var result = parking.LeaveParking();
            Console.WriteLine($"result is {result}");
            result = parking.LeaveParking();
            Console.WriteLine($"result is {result}");

            Console.WriteLine(parking);
            Console.WriteLine(parking.Capacity);
        }
    }
}
