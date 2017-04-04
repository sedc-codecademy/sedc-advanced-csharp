using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace G1_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region getting person type
            Type personType = typeof(Person);
            #endregion

            Console.WriteLine($"The class's name is {personType.Name}");

            Console.WriteLine("---PROPERTIES----");
            var personProperties = personType.GetProperties();
            foreach (var prop in personProperties)
            {
                Console.WriteLine($"Property {prop.Name}");
                Console.WriteLine($"  Property type is {prop.PropertyType}");
                Console.WriteLine(prop.CanRead ? "  Can be read": "  Cannot be read");
                Console.WriteLine(prop.CanWrite ? "  Can be writen" : "  Cannot be written");
            }

            Console.WriteLine("---FIELDS----");
            var personFields = personType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var field in personFields)
            {
                Console.WriteLine($"Field {field.Name}");
                Console.WriteLine($"  Field type is {field.FieldType}");
            }

            Console.WriteLine("---METHODS---");
            var personMethods = personType.GetMethods();
            foreach (var method in personMethods)
            {
                var parameters = method.GetParameters();
                Console.WriteLine($"Method {method.Name} has {parameters.Length} parameters");
                Console.WriteLine($"  Method return type is {method.ReturnType}");

                foreach (var param in parameters)
                {
                    Console.WriteLine($"  Parameter {param.Name} of type {param.ParameterType}");
                }
            }

            Console.WriteLine("---CONSTRUCTORS---");
            var personConstructors = personType.GetConstructors();
            foreach (var constructor in personConstructors)
            {
                var parameters = constructor.GetParameters();
                Console.WriteLine($"Constructor {constructor.Name} has {parameters.Length} parameters");

                foreach (var param in parameters)
                {
                    Console.WriteLine($"  Parameter {param.Name} of type {param.ParameterType}");
                }
            }

            Console.WriteLine("--- WORKING WITH OBJECTS ---");

            //var person = new Person("Wekoslav","Stefanovski");
            var weko = Activator.CreateInstance(personType, "Wekoslav", "Stefanovski");

            //person.Age = 0x27;

            personType.GetProperty("Age").SetValue(weko, 0x27);
            //personType.GetMethod("set_Age").Invoke(weko, new object[] { 0x27 });
            //personType.GetProperty("Age").GetSetMethod().Invoke(weko, new object[] { 0x27 });
            //personType.GetField("<Age>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance)
            //    .SetValue(weko, 0x27);

            //Console.WriteLine(person.GetFullName());
            Console.WriteLine(personType.GetMethod("GetFullName").Invoke(weko, null));
            //Console.WriteLine(person.Greet("Hi"));
            Console.WriteLine(personType.GetMethod("Greet").Invoke(weko, new object[] { "Hi" }));
            //person.AgeBy(5);
            personType.GetMethod("AgeBy").Invoke(weko, new object[] { 5 });

            //Console.WriteLine(person.Age);
            Console.WriteLine(personType.GetProperty("Age").GetValue(weko));

            Console.WriteLine("--- WORKING WITH DYNAMIC ---");

            dynamic dweko = Activator.CreateInstance(personType);
            dweko.FirstName = "Wekoslav";
            dweko.LastName = "Stefanovski";
            dweko.Age = 0x27;
            dweko.ID = 11;
            Console.WriteLine(dweko.GetFullName());
            Console.WriteLine(dweko.Greet("Hello"));
            dweko.AgeBy(10);
            Console.WriteLine(dweko.Age);

        }
    }
}
