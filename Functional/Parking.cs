using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional
{
    class Parking<T>
    {
        List<T> Vehicles;

        public void Park(T vehicle) { }

        public T LeaveParking()
        {
            return default(T);
        }

        int OccupiedPlaces;
        int FreePlaces;
        int Capacity;

        public Parking(int capacity)
        {

        }

    }
}
