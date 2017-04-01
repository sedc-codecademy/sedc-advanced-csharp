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

        static Dictionary<int, Func<string, IPayable>> dispatcher = new Dictionary<int, Func<string, IPayable>>
        {
            { 0, CreateBarber },
            { 1, CreateGrocer },
            { 2, (name) => CreateBaker(name, BourequeType.Leek)}
        };

        public static IPayable MakeClient(string name)
        {
            var random = r.Next(3);
            var clientCreator = dispatcher[random];
            return clientCreator(name);
        }

        private static IPayable CreateBaker(string name, BourequeType boureque)
        {
            var result = new Baker(name);
            result.SellBoureque(boureque);
            result.SellPie(PieType.Meat, PieSize.ExtraLarge);
            return result;
        }

        private static IPayable CreateGrocer(string name)
        {
            var result = new Grocer(name);
            result.Deposit(2000);
            return result;
        }

        private static IPayable CreateBarber(string name)
        {
            var result = new Barber(name);
            result.Deposit(1000);
            return result;
        }

        //public static IPayable MakeClient(string name)
        //{
        //    var random = r.NextDouble();

        //    if (random < (1.0 / 3))
        //    {
        //        var result = new Barber(name);
        //        result.Deposit(1000);
        //        return result;
        //    }
        //    else if (random < (2.0 / 3))
        //    {
        //        var result = new Grocer(name);
        //        result.Deposit(2000);
        //        return result;
        //    }
        //    else
        //    {
        //        var result = new Baker(name);
        //        result.SellBoureque(BourequeType.Leek);
        //        result.SellPie(PieType.Meat, PieSize.ExtraLarge);
        //        return result;
        //    }
        //}

        public static IPayable MakeBaker(string name)
        {
            var result = new Baker(name);
            result.Deposit(2000);
            return result;
        }
    }
}
