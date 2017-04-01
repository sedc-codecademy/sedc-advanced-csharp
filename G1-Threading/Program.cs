using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace G1_Threading
{
    class Program
    {
        static object lockObject = new object();
        static int inEvens = 10;

        static void Main(string[] args)
        {
            Thread evenThread = new Thread(new ThreadStart(PrintEvens));
            Thread oddThread = new Thread(new ThreadStart(PrintOdds));
            Thread evenThread2 = new Thread(new ThreadStart(PrintEvens));
            evenThread.Start();
            evenThread2.Start();
            oddThread.Start();
        }

        static void PrintEvens()
        {
            for (int i = 0; i < 10; i += 2)
            {
                lock (lockObject)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan; // 2, 5
                    Console.WriteLine($"ThreadID: {Thread.CurrentThread.ManagedThreadId}");
                    Console.WriteLine(i); // 4, 7
                }
                Thread.Sleep(1000);
            }
        }

        static void PrintOdds()
        {
            for (int i = 1; i < 11; i += 2)
            {
                lock (lockObject)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta; // 1, 6
                    Console.WriteLine(i); // 3, 8
                }
                Thread.Sleep(10);
            }
        }
    }
}
