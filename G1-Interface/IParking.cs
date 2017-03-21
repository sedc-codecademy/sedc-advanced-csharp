using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Interface
{
    interface IParking<T>
    {
        //1. да може да паркираме стварови
        void Park(T item);

        //2. да ги отпаркираме стваровите
        T LeaveParking();

        //3. да прашаме колку места има
        int Capacity { get; }

        //4. да прашаме колку слободни места има
        int FreePlaces { get; set; }

        //5. да прашаме колку зафатени места има
        int OccupiedPlaces { get; set; }

    }
}
