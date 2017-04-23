using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car Parking
            Parking<Car> carParking = new Parking<Car>(50);
            List<Car> cars = new List<Car>
            {
                new Car() { Make = "Ford" },
                new Car() { Make = "VW" },
                new Car() { Make = "Tesla" }
            };

            ParkingDemonstration(carParking, cars);

            // Truck Parking
            Parking<Truck> truckParking = new Parking<Truck>(30);
            List<Truck> trucks = new List<Truck>
            {
                new Truck() { Make = "Mercedes" },
                new Truck() { Make = "Volvo" },
                new Truck() { Make = "Renault" }
            };

            ParkingDemonstration(truckParking, trucks);

        }

        private static void ParkingDemonstration<TVehicle>(Parking<TVehicle> parking, List<TVehicle> vehicles)
        {
            string vehicleType = typeof(TVehicle).ToString();
            vehicleType = vehicleType.Substring(vehicleType.IndexOf('.') + 1).ToLower();

            Console.WriteLine($"Created a {vehicleType} parking with {parking.Capacity} parking spots.");
            Console.WriteLine($"Free spots: {parking.FreeSpots}");
            Console.WriteLine($"Occupied spots {parking.OccupiedSpots}");

            TVehicle vehicle1 = vehicles[0];
            TVehicle vehicle2 = vehicles[1];
            TVehicle vehicle3 = vehicles[2];

            Console.WriteLine($"\nParking a {vehicleType}...");
            parking.Park(vehicle1);
            Console.WriteLine($"Free spots: {parking.FreeSpots}");
            Console.WriteLine($"Occupied spots {parking.OccupiedSpots}");

            Console.WriteLine($"\nParking a {vehicleType}...");
            parking.Park(vehicle2);
            Console.WriteLine($"Free spots: {parking.FreeSpots}");
            Console.WriteLine($"Occupied spots {parking.OccupiedSpots}");

            Console.WriteLine($"\nParking a {vehicleType}...");
            parking.Park(vehicle3);
            Console.WriteLine($"Free spots: {parking.FreeSpots}");
            Console.WriteLine($"Occupied spots {parking.OccupiedSpots}");

            Console.WriteLine($"\nA {vehicleType} is leaving the parking...");
            parking.LeaveParking();
            Console.WriteLine($"Free spots: {parking.FreeSpots}");
            Console.WriteLine($"Occupied spots {parking.OccupiedSpots}");
            Console.WriteLine($"--------------------------------------\n");

        }
    }
}
