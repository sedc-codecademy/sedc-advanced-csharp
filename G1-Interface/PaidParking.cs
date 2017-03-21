using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Interface
{
    class PaidParking : StackParking<string>, IPayable
    {
        public int Balance { get; private set; }

        public int Price { get; set; }

        public PaidParking(int capacity, int price) : base(capacity)
        {
            Price = price;
            Balance = 0;
        }

        public override void Park(string vehicle)
        {
            base.Park(vehicle);
            Balance += Price;
        }

        public int Withdraw(int ammount)
        {
            if (Balance < ammount)
            {
                throw new WithdrawalException(ammount, Balance);
            }
            Balance -= ammount;
            return ammount;
        }
    }
}
