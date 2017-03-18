using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingG3
{
    class Parking<T>
    {
        private Queue<T> storage;

        public int Capacity { get; private set; }

        private int otherwiseOccupied;

        public int OccupiedPlaces
        {
            get
            {
                return storage.Count + otherwiseOccupied;
            }
            set
            {

            }
        }

        public Parking(int capacity)
        {
            Capacity = capacity;
            storage = new Queue<T>();
            otherwiseOccupied = 0;
        }

        public override string ToString()
        {
            return $"I'm a parking with a capacity of {Capacity}";
        }

        public bool IsFull()
        {
            return false;
        }

        public bool HasVehicles()
        {
            return storage.Count == 0;
        }

        public void Park(T vehicle)
        {
            if (storage.Count == Capacity)
            {
                throw new InvalidOperationException("Parking is full");
            }
            storage.Enqueue(vehicle);
        }

        public T LeaveParking()
        {
            if (storage.Count == 0)
            {
                throw new InvalidOperationException("Parking is empty");
            }
            return storage.Dequeue();
        }

    }
}
