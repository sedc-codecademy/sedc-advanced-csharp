using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int>();

            for (var i = 0; i < 10; i++)
            {
                x.Add(i * i);
            }

            var helper = new ListHelper();
            helper.PrintList(x);

            List<string> names = new List<string> {
                "Wekoslav Stefanovski",
                "Dragan Sekulovski",
                "Ines Rasic",
                "Dhurata Nebiu"
            };

            helper.PrintList(names);


            List<Dog> doges = new List<Dog>
            {
                new Dog { Name="Rex", Age = 3 },
                new Dog { Name="Fluffy", Age =7 }
            };

            helper.PrintList(doges);

            Console.WriteLine(helper.GetLastElement(doges));
            Console.WriteLine(helper.GetLastElement(names));
            Console.WriteLine(helper.GetLastElement(x));


            List<bool> bools = new List<bool>();
            Console.WriteLine(helper.GetLastElement(bools));

            var list = new List<DateTime>();
            Console.WriteLine(helper.GetLastElement(list));

            var cars = new List<Car>
            {
                new Car { Make="Opel", Model="Astra", EngineType=EngineType.Petrol, FailedSparkPlugs = 2 },
                new Car { Make="Tesla", Model="Model S", EngineType=EngineType.Electric, FailedSparkPlugs = null },
            };

            helper.PrintList(cars);
        }
    }
}
