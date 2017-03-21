using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Interface
{
    class Barber : IPayable
    {
        public Barber(string name)
        {
            Name = name;
            Balance = 0;
            Price = 100;
        }

        public string Name { get; set; }
        public int Balance { get; private set; }
        public int Price { get; set; }

        public int Withdraw(int ammount)
        {
            if (Balance < ammount)
            {
                throw new WithdrawalException(ammount, Balance);
            }
            Balance -= ammount;
            return ammount;
        }

        public void CutHair(string name)
        {
            Console.WriteLine($"Giving {name} a nice haircut");
            Balance += Price;
        }

        public void Shave(string name)
        {
            Console.WriteLine($"Giving {name} a close shave");
            Balance += Price;
        }

        public void Makeover(string name)
        {
            Console.WriteLine($"Giving {name} a complete makeover");
            Balance += 5 * Price;
        }
    }
}
