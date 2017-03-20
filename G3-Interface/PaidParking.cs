using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Interface
{
    class PaidParking : StringParking, IPayable
    {
        public PaidParking(int capacity, int price): base(capacity)
        {
            Price = price;
        }

        public int Balance { get; private set; }

        public int Price { get; set; }

        public override void Park(string vehicle)
        {
            Balance += Price;
            base.Park(vehicle);
        }

        public void Withdraw(int ammount)
        {
            if (Balance < ammount)
                throw new WithdrawException(ammount, Balance);
            Balance -= ammount;
        }

        public override string ToString()
        {
            return $"Paid Parking: Capacity {Capacity}, Occupied {OccupiedPlaces}, Balance {Balance} MKD";
        }
    }
}
