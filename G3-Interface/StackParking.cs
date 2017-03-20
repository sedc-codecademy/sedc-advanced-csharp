using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Interface
{
    class StackParking<T> : IParking<T>
    {
        public StackParking(int capacity)
        {
            Capacity = capacity;
            OccupiedPlaces = 0;
            repository = new Stack<T>();
        }

        public int Capacity { get; private set; }
        public int OccupiedPlaces { get; private set; }

        public int FreePlaces
        {
            get
            {
                return Capacity - OccupiedPlaces;
            }
        }


        Stack<T> repository;

        public T LeaveParking()
        {
            OccupiedPlaces--;
            return repository.Pop();
        }

        public void Park(T vehicle)
        {
            OccupiedPlaces++;
            repository.Push(vehicle);
        }
    }
}
