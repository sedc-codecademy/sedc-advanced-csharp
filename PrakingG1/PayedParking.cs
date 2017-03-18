using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakingG1
{
    class PayedParking<T> : Parking<T>
    {
        public int Price { get; private set; }
        public int Balance { get; private set; }

        public PayedParking(int capacity, int price) : base(capacity)
        {
            Price = price;
            Balance = 0;
        }

        public override void Park(T vehicle)
        {
            Console.WriteLine("Derived Park");
            base.Park(vehicle);
            Balance += Price;
        }

    }
}
