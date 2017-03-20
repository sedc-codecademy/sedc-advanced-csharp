using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Interface
{
    class StringParking : IParking<string>
    {
        public StringParking(int capacity)
        {
            Capacity = capacity;
            FreePlaces = capacity;
            repository = new Queue<string>();
        }


        public int Capacity { get; private set; }
        public int FreePlaces { get; private set; }
        public int OccupiedPlaces {
            get {
                return Capacity - FreePlaces;
            }
        }

        Queue<string> repository;

        public string LeaveParking()
        {
            FreePlaces++;
            return repository.Dequeue();
        }

        public void Park(string vehicle)
        {
            FreePlaces--;
            repository.Enqueue(vehicle);
        }
    }
}
