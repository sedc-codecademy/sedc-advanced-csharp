using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Reflection
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int ID { get; private set; }

        public string FullName
        {
            get
            {
                return GetFullName();
            }
        }

        public Person()
        {
            ID = 1;
        }

        public Person(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string Greet(string greeting)
        {
            return $"{greeting}, {FirstName}";
        }

        public void AgeBy(int age)
        {
            Age+=age;
        }

        public override string ToString()
        {
            return GetFullName();
        }
    }
}
