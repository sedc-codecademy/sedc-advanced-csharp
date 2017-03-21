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
            PaidParking p = new PaidParking(20, 100);
            p.Park("Audi");
            p.Park("Mercedes");
            p.Park("Ford");
            p.Park("Opel");
            p.Withdraw(100);

            Barber b = new Barber("Brico");
            b.CutHair("Weko");
            b.Shave("Petar");
            b.Makeover("Aneta");

            Console.WriteLine(b.Balance);

            Mobster tony = new Mobster("Tony", "Knife");
            tony.AddClient(p);
            tony.AddClient(b);

            Console.WriteLine($"The parking has {p.Balance} denars");
            Console.WriteLine($"{b.Name} has {b.Balance} denars");
            Console.WriteLine($"{tony.Name} the {tony.Nickname} has {tony.Balance} denars");

            tony.TakeCareOfBusiness();

            Console.WriteLine($"The parking has {p.Balance} denars");
            Console.WriteLine($"{b.Name} has {b.Balance} denars");
            Console.WriteLine($"{tony.Name} the {tony.Nickname} has {tony.Balance} denars");

            //IParking<string> parking = GetMeAParking();
            //parking.Park("Audi");
            //parking.Park("Mercedes");
            //parking.Park("Yugo");

            //parking.LeaveParking();

        }

        static IParking<string> GetMeAParking()
        {
            Random r = new Random();
            if (r.NextDouble() > 0.5)
            {
                return new StackParking<string>(20);
            }
            else
            {
                return new QueueParking<string>(20);
            }
        }
    }
}
