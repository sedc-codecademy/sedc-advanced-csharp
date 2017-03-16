using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("Wekoslav");
            SetAccountBalance(acc, 1000);

            SetAccountBalance(acc, 2000);

            SetAccountBalance(acc, -1500);

            acc.Balance += 5;
            Console.WriteLine(acc);
            Console.WriteLine(acc.AccountName);

        }

        private static void SetAccountBalance(Account acc, int ammount)
        {
            try
            {
                acc.Balance = ammount;
                Console.WriteLine(acc);
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine($"Something went wrong: {aex.Message} ");
            }
            finally
            {
                Console.WriteLine("Setting finished");
            }
        }
    }
}
