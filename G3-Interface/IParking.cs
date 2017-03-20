using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Interface
{
    interface IParking<T>
    {
        void Park(T vehicle);
        T LeaveParking();
        int FreePlaces {get; }
        int OccupiedPlaces { get; }
        int Capacity { get; }
        
        //1. Should be able to park
        //2. should be able to unpark
        //3. should be able to get free places
        //4. should be able to get occupied places
        //5. should be able to get capacity
    }
}
