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

        private int occupiedPlaces;
        public int OccupiedPlaces
        {
            get
            {
                return occupiedPlaces;
            }
            set
            {
                if (value < vehicles.Count)
                {
                    throw new ArgumentException("Value cannot be less than vehicle count");
                }
                if (value > Capacity)
                {
                    throw new ArgumentException("Value cannot be greater than capacity");
                }
                occupiedPlaces = value;
            }
        }

        public int FreePlaces
        {
            get
            {
                return Capacity - occupiedPlaces;
            }
            set
            {
                OccupiedPlaces = Capacity - value;
            }
        }

        public Parking(int capacity)
        {
            Capacity = capacity;
            vehicles = new Queue<T>();
        }

        public override string ToString()
        {
            return $"Hi I'm a parking with {Capacity} places";
        }

        public void Park(T vehicle)
        {
            vehicles.Enqueue(vehicle);
            occupiedPlaces++;
        }

        public T LeaveParking()
        {
            var vehicle = vehicles.Dequeue();
            occupiedPlaces--;
            return vehicle;
        }
    }
}
