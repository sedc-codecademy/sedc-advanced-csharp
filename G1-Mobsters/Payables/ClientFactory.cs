using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Mobsters.Payables
{
    public static class ClientFactory
    {
        static Random r;

        static ClientFactory()
        {
            r = new Random();
        }

        public static IPayable MakeClient(string name)
        {
            var random = r.NextDouble();

            if (random < (1.0 / 3))
            {
                var result = new Barber(name);
                result.Deposit(1000);
                return result;
            }
            else if (random < (2.0 / 3))
            {
                var result = new Grocer(name);
                result.Deposit(2000);
                return result;
            }
            else
            {
                var result = new Baker(name);
                result.SellBoureque(BourequeType.Leek);
                result.SellPie(PieType.Meat, PieSize.ExtraLarge);
                return result;
            }
        }

        public static IPayable MakeBaker(string name)
        {
            var result = new Baker(name);
            result.Deposit(2000);
            return result;
        }
    }
}
