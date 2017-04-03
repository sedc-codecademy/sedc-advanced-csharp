using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace G3_Reflect
{
    class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);

            var properties = personType.GetProperties();

            foreach (var prop in properties)
            {
                Console.WriteLine($"Class {prop.DeclaringType} has the property: {prop.Name} of type {prop.PropertyType}");
            }

            var methods = personType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var method in methods)
            {
                Console.WriteLine($"Class {method.DeclaringType} has the method: {method.Name}");
                var parameters = method.GetParameters();
                Console.WriteLine("Parameters: ");
                foreach (var param in parameters)
                {
                    Console.WriteLine($"  {param.Name} of type {param.ParameterType}");
                }
                Console.WriteLine($"  returns {method.ReturnType}");
            }

            var fields = personType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                Console.WriteLine($"Class {field.DeclaringType} has the method: {field.Name}");
            }

            var constructors = personType.GetConstructors();
            foreach (var ctor in constructors)
            {
                Console.WriteLine($"Class {ctor.DeclaringType} has the method: {ctor.Name}");
                var parameters = ctor.GetParameters();
                Console.WriteLine("Parameters: ");
                foreach (var param in parameters)
                {
                    Console.WriteLine($"  {param.Name} of type {param.ParameterType}");
                }
            }

            // var weko = new Person();
            var weko = Activator.CreateInstance(personType);

            // weko.FirstName = "Wekoslav"
            personType.GetProperty("FirstName").SetValue(weko, "Wekoslav");

            // weko.LastName = "Stefanovski"
            personType.GetField("<LastName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(weko, "Stefanovski");

            // string lastname = weko.LastName;
            string lastname = (string)personType.GetProperty("LastName").GetGetMethod().Invoke(weko, null);
            Console.WriteLine(lastname);

            // string greet = weko.Greet("Hi");
            string greet = (string)personType.GetMethod("Greet").Invoke(weko, new object[] { "Hi" });
            Console.WriteLine(greet);

            //Console.WriteLine(weko);

            dynamic dweko = Activator.CreateInstance(personType);
            dweko.FirstName = "Wekoslav";
            dweko.LastName = "Stefanovski";
            var greet2 = dweko.Greet("Hello");
            Console.WriteLine(greet2);
            Console.WriteLine(dweko);
        
        }
    }
}
