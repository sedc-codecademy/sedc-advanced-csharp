using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    // Regarding commented code: I eliminated the private fields for the properties and their increment / decrement operations.
    // The properties are implemented using just _vehicles List field.
    class Parking<T>
    {
        List<T> _vehicles;
        //readonly int _capacity;
        //int _occupiedSpots = 0;
        //int _freeSpots;

        public int Capacity
        {
            get { return _vehicles.Capacity; }
        }
        
        public int OccupiedSpots
        {
            get { return _vehicles.Count; }
        }
        public int FreeSpots
        {
            get { return _vehicles.Capacity - _vehicles.Count; }
        }

        public Parking(int capacity)
        {
            //_capacity = capacity;
            //_freeSpots = capacity;
            _vehicles = new List<T>(capacity);
        }

        public void Park(T vehicle)
        {
            _vehicles.Add(vehicle);
            //_freeSpots--;
            //_occupiedSpots++;
        }

        public T LeaveParking()
        {
            T vehicle = _vehicles.Last();
            _vehicles.RemoveAt(_vehicles.Count - 1);
            //_occupiedSpots--;
            //_freeSpots++;
            return vehicle;
        }
    }
}
