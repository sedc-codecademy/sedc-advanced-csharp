using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> students = new string[]
            {
                "Aneta",
                "Igor",
                "Marjan",
                "Robert",
                "Blagoja",
                "Stefan",
                "Boban",
                "Filip",
                "Filip",
                "Mile",
                "Nenad",
                "Gjorgi",
                "Ivana",
                "Irena"
            };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("-----------------");

            var longest = students
                .OrderByDescending(s => s.Length)
                .First();

            Console.WriteLine(longest);

            Console.WriteLine("-----------------");

            var lenghtTest = students.Any(s => s.Length > 9);
            Console.WriteLine(lenghtTest);

            Console.WriteLine("-----------------");
            var obtained = students.SingleOrDefault(s => s == "Ivana");
            Console.WriteLine(obtained);

            Console.WriteLine("-----------------");
            var mapped = students
                .Where(s => s[0] > 'F')
                .Select(s => s.Length)
                .Average();
            Console.WriteLine(mapped);

            Console.WriteLine("-----------------");
            var groups = students.GroupBy(s => s.Length).OrderBy(g => g.Key);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine($"    {student}");
                }
            }

            Console.WriteLine("-----------------");
            var sgs = groups.Select(g => new
            {
                NameLength = g.Key,
                StudentCount = g.Count()
            });

            foreach (var sg in sgs)
            {
                Console.WriteLine($"{sg.NameLength}   {sg.StudentCount}");
            }

            Console.WriteLine("-----------------");
            var lengths = students.OrderBy(s => s.Length).Select(s =>
            {
                Console.WriteLine($"Getting length for {s}");
                return s.Length;
            });

            Console.WriteLine("Printing students");

            foreach (var len in lengths.TakeWhile(l => l < 6))
            {
                Console.WriteLine(len);
            }
        }
    }

    //class StudentGroup
    //{
    //    public int NameLength { get; set; }
    //    public int StudentCount { get; set; }

    //}
}
