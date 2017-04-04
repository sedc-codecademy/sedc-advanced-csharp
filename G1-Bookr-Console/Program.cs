using Entities;
using Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Bookr_Console
{
    class Program
    {
        static NestedAuthor selectedAuthor;
        static List<NestedAuthor> nauthors;

        static Dictionary<string, Action> dispatcher;


        static void Main(string[] args)
        {
            var option = Options.OptionThree | Options.OptionFour | Options.OptionOne;
            Console.WriteLine(option);
            return;

            //device?.DeviceConfiguration?.Channel?.ChannelMeasurement?.Algoritm?.AlgorithmType

            //int? novelCount = (selectedAuthor.Novels != null) ? selectedAuthor.Novels.Count() : (int?)null;
            //int? novelCoun2 = selectedAuthor.Novels?.Count();

            dispatcher = new Dictionary<string, Action>
            {
                { "a", AddAuthor },
                { "n", AddNovel },
                { "c", CountStuff },
                { "s", SelectAuthor },
                { "d", () => { Console.WriteLine("DEMO"); } }
            };

            string authorsText = File.ReadAllText("authors.json");
            var mapper = new JsonParser();
            var authors = mapper.ParseAuthors(authorsText).ToList();

            Console.WriteLine($"Loaded {authors.Count()} authors");

            string novelsText = File.ReadAllText("novels.json");
            var novels = mapper.ParseNovels(novelsText).ToList();
            Console.WriteLine($"Loaded {novels.Count()} novels");

            AuthorManager am = new AuthorManager();
            nauthors = am.TransformData(authors, novels).ToList();
            selectedAuthor = nauthors.First();

            foreach (var author in nauthors)
            {
                author.NovelAdded += NotifyMarketing;
            }

            while (true)
            {
                Console.Write("Enter command: ");
                var command = Console.ReadLine();

                if (dispatcher.ContainsKey(command))
                {
                    dispatcher[command]();
                }

            }
        }

        private static void NotifyMarketing(object sender, NovelAddedEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine($"!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine($"BYU NOW {e.Title} by {e.Author}");
            Console.WriteLine($"!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }

        private static void CountStuff()
        {
            Console.WriteLine($"Have {nauthors.Count()} authors");
            Console.WriteLine($"Have {nauthors.Sum(a => a.Novels.Count())} novels");

            Console.WriteLine($"Selected author is {selectedAuthor}");
            Console.WriteLine($"Selected author's novels:");
            foreach (var novel in selectedAuthor.Novels)
            {
                Console.WriteLine($"  {novel}");
            }
        }

        private static void SelectAuthor()
        {
            Console.Write("Enter author id: ");
            var selectedAuthodId = int.Parse(Console.ReadLine());

            var author = nauthors.SingleOrDefault(a => a.Id == selectedAuthodId);

            if (author == null)
            {
                Console.WriteLine($"Author with ID {selectedAuthodId} not found");
                return;
            }

            selectedAuthor = author;
        }

        private static void AddNovel()
        {
            Console.Write("Enter novel title: ");
            var title = Console.ReadLine();

            if (selectedAuthor.Novels.Any(n => n.Title == title))
            {
                Console.WriteLine("Already have that one");
                return;
            }

            var id = nauthors.SelectMany(a => a.Novels).Max(n => n.Id) + 1;

            var novel = new NestedNovel
            {
                Id = id,
                Title = title,
                Author = selectedAuthor,
            };
            selectedAuthor.AddNovel(novel);
        }

        private static void AddAuthor()
        {
            Console.Write("Enter author name: ");
            var name = Console.ReadLine();
            var id = nauthors.Max(a => a.Id) + 1;

            if (nauthors.Any(a => a.Name == name))
            {
                Console.WriteLine("Already have that one");
                return;
            }

            var author = new NestedAuthor { Name = name, Id = id };
            author.NovelAdded += NotifyMarketing;
            nauthors.Insert(0, author);
            selectedAuthor = author;
        }
    }
}
