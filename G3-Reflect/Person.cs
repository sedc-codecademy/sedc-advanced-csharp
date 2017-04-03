using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Reflect
{
    public class Person
    {
        public int Age { get; set; }
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName)
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

        public override string ToString()
        {
            return GetFullName();
        }
    }
}
