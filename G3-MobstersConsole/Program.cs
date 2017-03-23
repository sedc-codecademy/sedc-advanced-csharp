using G3_Mobsters;
using G3_Mobsters.Payables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_MobstersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var allPrimes = GetAllPrimes();

            var underMillion = allPrimes.TakeWhile(p => p < 1000000).Count();

            Console.WriteLine(underMillion);

            return;
            var random = new Random();
            var result = Enumerable.Repeat(0, 10).Select(_ =>
            {
                Console.WriteLine("Generating random number");
                return random.Next(10000);
            }).Take(3);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

            return;
            IEnumerable<string> students = new List<string>()
            {
                "Weko",
                "Sasho",
                "Dragan",
                "Granit",
                "Dhurata",
                "Filip",
                "Ines",
                "Cvetko",
                "Stefan"
            };

            var modifieds = students.Where(s => s.Length > 5).Select(s => new
            {
                Name = s,
                UpperName = s.ToUpper(),
                LowerName = s.ToLower(),
                Length = s.Length
            });

            foreach (var student in modifieds)
            {
                Console.WriteLine($"{student.Name} - {student.LowerName} - {student.UpperName} - {student.Length}");
            }

            foreach (var student in students
                .OrderBy(s => s[0])
                .ThenByDescending(s => s.Length)
                .SkipWhile(s => s[0] < 'E')
                .TakeWhile(s => s[0] < 'W'))
            {
                Console.WriteLine(student);
            }

            var groups = students.GroupBy(s => s.Length);
            //foreach (var group in groups)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var student in group)
            //    {
            //        Console.WriteLine($"  {student}");
            //    }
            //}

            var summedGroups = groups.Select(g => new
            {
                Key = g.Key,
                Count = g.Count()
            });

            foreach (var sum in summedGroups)
            {
                Console.WriteLine($"{sum.Key}: {sum.Count}");
            }

            return;
            Mobster tony = new Mobster("Tony", "Nose");
            Console.WriteLine(tony);

            for (int i = 0; i < 10; i++)
            {
                var client = ClientFactory.CreateClient($"Client{i + 1}");
                tony.AddClient(client);
            }

            Console.WriteLine(tony.CountNiceClients());
            tony.TakeCareOfBusiness();

            Console.WriteLine(tony);
        }

        static IEnumerable<int> GetAllPrimes()
        {
            yield return 2;
            yield return 3;
            var index = 3;
            while (true)
            {
                index += 2;
                bool isPrime = true;
                for (int i = 3; i < Math.Sqrt(index); i++)
                {
                    if (index % i == 0)
                    {
                        isPrime = false;
                        continue;
                    }
                }
                if (isPrime)
                    yield return index;
            }
        }
    }
}
