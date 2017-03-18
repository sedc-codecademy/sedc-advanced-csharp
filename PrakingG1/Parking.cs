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
        public int OccupiedPlaces {
            get {

            }
            set {

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
        }

        public T LeaveParking()
        {
            var vehicle = vehicles.Dequeue();
            return vehicle;
        }
    }
}
