using G3_Mobsters;
using G3_Mobsters.Payables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_MobstersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobster tony = new Mobster("Tony","Nose");
            Console.WriteLine(tony);

            for (int i = 0; i < 10; i++)
            {
                var client = ClientFactory.CreateClient($"Client{i + 1}");
                tony.AddClient(client);
            }

            tony.TakeCareOfBusiness();

            Console.WriteLine(tony);


        }
    }
}
