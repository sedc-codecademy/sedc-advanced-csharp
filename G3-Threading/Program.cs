using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace G3_Threading
{
    class Program
    {
        static object lockObject = new object();

        static void Main(string[] args)
        {
            Thread evens = new Thread(new ThreadStart(PrintEvens));
            Thread odds = new Thread(new ThreadStart(PrintOdds));
            evens.Start();
            odds.Start();
        }

        static void PrintEvens()
        {
            for (int i = 0; i < 10; i+=2)
            {
                lock (lockObject)
                {
                    Console.ForegroundColor = ConsoleColor.Blue; // 2
                    Console.WriteLine(i); // 4 - blue "0"
                }
                Thread.Sleep(10);
            }
        }

        static void PrintOdds()
        {
            for (int i = 1; i < 10; i += 2)
            {
                lock (lockObject)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // 1 
                    Console.WriteLine(i); // 3 - blue "1" 
                }
                Thread.Sleep(10);
            }
        }

    }
}
