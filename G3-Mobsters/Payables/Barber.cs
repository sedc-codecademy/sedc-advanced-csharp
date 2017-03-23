using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Mobsters.Payables
{
    internal class Barber : IPayable
    {
        public string Name { get; set; }

        public Barber(string name)
        {
            Name = name;
            Price = 100;
            Balance = 0;
        }

        public int Balance { get; private set; }

        public int Price { get; set; }

        public int Withdraw(int ammount)
        {
            if (Balance < ammount)
                throw new WithdrawException(ammount, Balance);
            Balance -= ammount;
            return ammount;
        }

        public void MakeHaircut(string client)
        {
            Balance += Price;
        }

        public void Shave(string client)
        {
            Balance += 2 * Price;
        }

        public void Makeover(string client)
        {
            Balance += 10 * Price;
        }

        public override string ToString()
        {
            return $"I'm {Name} the barber and I have {Balance} denars";
        }
    }
}
