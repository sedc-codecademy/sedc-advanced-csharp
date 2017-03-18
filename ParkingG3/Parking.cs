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

        private int reserved;

        public int OccupiedPlaces
        {
            get
            {
                return storage.Count + reserved;
            }
            set
            {
                if (value < storage.Count)
                {
                    throw new Exception("Cannot have less occupied places then cars");
                }
                if (value > Capacity)
                {
                    throw new Exception("Cannot have more occupied places then places");
                }
                reserved = value - storage.Count;
            }
        }

        public int FreePlaces
        {
            get
            {
                return Capacity - OccupiedPlaces;
            }
            set
            {
                OccupiedPlaces = Capacity - value;
            }
        }

        public Parking(int capacity)
        {
            Capacity = capacity;
            storage = new Queue<T>();
            reserved = 0;
        }

        public override string ToString()
        {
            return $"I'm a parking with a capacity of {Capacity} and {FreePlaces} available.";
        }

        public bool IsFull()
        {
            return false;
        }

        public bool HasVehicles()
        {
            return storage.Count == 0;
        }

        public virtual void Park(T vehicle)
        {
            if (storage.Count == Capacity)
            {
                throw new InvalidOperationException("Parking is full");
            }
            storage.Enqueue(vehicle);
        }

        public virtual T LeaveParking()
        {
            if (storage.Count == 0)
            {
                throw new InvalidOperationException("Parking is empty");
            }
            return storage.Dequeue();
        }
    }
}
