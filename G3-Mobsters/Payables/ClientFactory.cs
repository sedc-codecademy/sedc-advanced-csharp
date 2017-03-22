using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Mobsters.Payables
{
    public static class ClientFactory
    {
        public static IPayable CreateClient(string name)
        {
            Random r = new Random();

            if (r.NextDouble() > 0.5)
            {
                Barber b = new Barber(name);
                b.MakeHaircut("client1");
                b.Makeover("client");
                b.Shave("client3");
                return b;
            }
            else
            {
                Grocer g = new Grocer(name);
                g.SellVegetable("Tomatoes", 3);
                g.SellVegetable("Peppers", 1);
                g.SellVegetable("Leek");
                return g;
            }
        }

    }
}
