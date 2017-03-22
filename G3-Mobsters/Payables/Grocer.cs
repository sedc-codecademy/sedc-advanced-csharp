using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Mobsters.Payables
{
    internal class Grocer : IPayable
    {
        public string Name { get; set; }

        public Grocer(string name)
        {
            Name = name;
            Price = 100;
            Balance = 0;
        }

        public int Balance { get; private set; }

        public int Price { get; set; }

        public void Withdraw(int ammount)
        {
            if (Balance < ammount)
                throw new WithdrawException(ammount, Balance);
            Balance -= ammount;
        }

        public void SellVegetable(string vegetable, int factor = 1)
        {
            Balance += factor * Price;
        }

        public override string ToString()
        {
            return $"I'm {Name} the groces and I have {Balance} denars";
        }
    }
}
