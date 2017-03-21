using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Interface
{
    class StackParking<T> : IParking<T>
    {
        Stack<T> vehicles;

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

        public StackParking(int capacity)
        {
            Capacity = capacity;
            vehicles = new Stack<T>();
        }

        public override string ToString()
        {
            return $"Hi I'm a parking with {Capacity} places";
        }

        public virtual void Park(T vehicle)
        {
            Console.WriteLine($"Parking car {vehicle}");
            if (occupiedPlaces == Capacity)
            {
                throw new InvalidOperationException("Parking is full.");
            }
            occupiedPlaces++;
            vehicles.Push(vehicle);
        }

        public virtual T LeaveParking()
        {
            if (vehicles.Count == 0)
            {
                throw new InvalidOperationException("Parking is empty.");
            }
            var vehicle = vehicles.Pop();
            Console.WriteLine($"Car {vehicle} leaving parking");
            occupiedPlaces--;
            return vehicle;
        }

        public void DoSomething()
        {

        }
    }
}
