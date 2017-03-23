using G1_Mobsters;
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

            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
                string tonyName = tony.ToString();
            }
            
            
        }
    }
}
