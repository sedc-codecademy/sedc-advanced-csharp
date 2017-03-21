using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IParking<string> parking = new StackParking<string>(20);
            parking.Park("Audi");
            parking.Park("Mercedes");
            parking.Park("Yugo");

            parking.LeaveParking();

        }
    }
}
