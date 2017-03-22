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

        public void Withdraw(int ammount)
        {
            if (Balance < ammount)
                throw GenerateWithdrawException(ammount);
            Balance -= ammount;
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

        public Exception GenerateWithdrawException(int ammount)
        {
            var result = new WithdrawException(ammount, Balance);
            return result;
        }

        public override string ToString()
        {
            return $"I'm {Name} the barber and I have {Balance} denars";
        }
    }
}
