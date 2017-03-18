using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingG3
{
    class PayedParking<T> : Parking<T>
    {
        public int Price { get; private set; }
        public int Balance { get; private set; }

        public PayedParking(int price, int capacity): base(capacity)
        {
            Price = price;
        }

        public override string ToString()
        {
            return base.ToString() + $" The price is {Price}";
        }

        public override void Park(T vehicle)
        {
            Balance += Price;
            base.Park(vehicle);
        }

        public void Withdraw(int ammount)
        {
            Balance -= ammount;
        }



    }
}
