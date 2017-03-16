using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public EngineType EngineType { get; set; }

        public int? FailedSparkPlugs { get; set; }

        public override string ToString()
        {
            if (FailedSparkPlugs == null)
                return $"{Make} {Model}";
            else 
                return $"{Make} {Model} ({FailedSparkPlugs} failed spark plugs)";
        }
    }

    enum EngineType
    {
        Diesel,
        Petrol,
        Electric
    }
}
