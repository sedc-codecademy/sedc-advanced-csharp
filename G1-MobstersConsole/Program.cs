using G1_Mobsters;
using G1_Mobsters.Payables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace G1_MobstersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobster tony = new Mobster("Tony","Nose");
            for (int i = 0; i < 20; i++)
            {
                tony.AddClient(ClientFactory.MakeClient($"Client #{i+1}"));
            }

            Console.WriteLine("----BEFORE----");
            Console.WriteLine(tony);
            foreach (var client in tony.ListClients())
            {
                Console.WriteLine(client);
            }

            tony.TakeCareOfBusiness();

            Console.WriteLine("----AFTER----");
            Console.WriteLine(tony);
            foreach (var client in tony.ListClients())
            {
                Console.WriteLine(client);
            }

            tony.GiveCharity();
        }
    }
}
