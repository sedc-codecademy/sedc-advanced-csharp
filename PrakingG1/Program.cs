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
            Console.WriteLine(car);

            car = parking.LeaveParking();
            Console.WriteLine(car);

            car = parking.LeaveParking();
            Console.WriteLine(car);

            Console.WriteLine(parking);
        }
    }
}
