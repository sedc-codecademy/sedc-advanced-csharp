using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> pets = new List<Animal>();

            pets.Add(new Dog { Name = "Rex", IsLarge = true });
            pets.Add(new Dog { Name = "Fiffy", IsLarge = false });
            pets.Add(new Cat { Name = "Moni"});

            foreach (var pet in pets)
            {
                Console.WriteLine(pet.MakeSound());
            }
        }
    }
}
