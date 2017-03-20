using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IParking<string> someParking = new StackParking<string>(20);
            Console.WriteLine(someParking.OccupiedPlaces);
            someParking.Park("Audi");
            someParking.Park("BMW");
            Console.WriteLine(someParking.OccupiedPlaces);
            var firstOut = someParking.LeaveParking();
            Console.WriteLine(firstOut);


            Barber jean = new Barber("Jean");
            jean.MakeHaircut("bob");
            jean.Shave("jim");
            jean.Makeover("alice");

            PaidParking paidParking = new PaidParking(20, 50);
            paidParking.Park("Ferrari");
            paidParking.Park("Yugo");
            paidParking.Park("Volga");

            Console.WriteLine(paidParking.Balance);
            Console.WriteLine(paidParking.OccupiedPlaces);

            List<IPayable> clients = new List<IPayable>
            {
                jean,
                paidParking
            };

            var kingpin = new Mobster("Tony");

            kingpin.AddClient(jean);
            kingpin.AddClient(paidParking);

            Console.WriteLine(jean);
            Console.WriteLine(paidParking);
            kingpin.TakeCareOfBusiness();
            Console.WriteLine(jean);
            Console.WriteLine(paidParking);





        }
    }
}
