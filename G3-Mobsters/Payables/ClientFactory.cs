using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Mobsters.Payables
{
    public static class ClientFactory
    {
        static Random r;

        static ClientFactory()
        {
            //Console.WriteLine($"Initializing random. Time is {DateTime.Now.Ticks}");
            r = new Random();
        }

        public static IPayable CreateClient(string name)
        {
            if (r.NextDouble() > 0.5)
            {
                Barber b = new Barber(name);
                do
                {
                    b.MakeHaircut("client1");
                    b.Makeover("client");
                    b.Shave("client3");
                }
                while (r.NextDouble() > 0.4);
                return b;
            }
            else
            {
                Grocer g = new Grocer(name);
                do
                {
                    g.SellVegetable("Tomatoes", 4);
                    g.SellVegetable("Peppers", 1);
                    g.SellVegetable("Leek");
                }
                while (r.NextDouble() > 0.4);
                return g;
            }
        }

    }
}
