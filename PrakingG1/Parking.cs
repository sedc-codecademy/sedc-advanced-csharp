using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakingG1
{
    class Parking<T>
    {
        Queue<T> vehicles;

        public int Capacity { get; private set; }

        public Parking(int capacity)
        {
            Capacity = capacity;
        }

        public override string ToString()
        {
            return $"Hi I'm a parking with {Capacity} places";
        }

        public void Park(T vehicle)
        {

        }

        public T LeaveParking()
        {
            return default(T);
        }
    }
}
