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
            
        }
    }
}
